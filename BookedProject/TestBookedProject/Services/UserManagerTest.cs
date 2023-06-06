using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Exceptions;
using Booked.Logic.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBookedProject.Mocks;

namespace TestBookedProject.Services
{
	[TestClass]
	public class UserManagerTest
	{
		[TestMethod]
		public void AddUserTest()
		{
			UserManager manager = new UserManager(new FakeUserRepo());
			User user = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");

			manager.AddUser(user);
			int i = manager.GetAllUsers().Count();

			Assert.AreEqual(1, i);
		}

		[TestMethod]
		public void AddSameEmailUserTest_ShouldThrowException()
		{
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            User user2 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            
			manager.AddUser(user1);

            Assert.ThrowsException<EmailExistException>(() => manager.AddUser(user2), "User email already exist");
        }

        [TestMethod]
        public void CheckPasswordUserTest_When_Password_Correct()
        {
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            string email = "s.chen@company.nl";

            manager.AddUser(user1);
            bool result = manager.CheckPassword("password", email);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckPasswordUserTest_When_Password_Incorrect()
        {
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            string email = "s.chen@company.nl";

            manager.AddUser(user1);
            bool result2 = manager.CheckPassword("test", email);

            Assert.IsFalse(result2);
        }

        [TestMethod]
		public void RemoveUserTest()
		{
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            User user3 = new User("Steve", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password");


            manager.AddUser(user1);
			manager.AddUser(user3);
			manager.DeleteUser(user1.UserId);

			Assert.AreEqual(1, manager.GetAllUsers().Count());
        }

		[TestMethod]
		public void RemoveUser_ID_Not_Exist_ShouldThrowException()
		{
			UserManager manager = new UserManager(new FakeUserRepo());
			User user1 = new User(1,"Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
			User user3 = new User("Steve", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password");


			manager.AddUser(user1);
			manager.DeleteUser(user1.UserId);

			Assert.ThrowsException<Exception>(() => manager.DeleteUser(1), "Cannot remove user");
		}

		[TestMethod]
		public void UpdateUserTest()
		{
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User(1,"Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password"); 
			User user2 = new User(1,"Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 3, 3), "33789987", "password");

			manager.AddUser(user1);
			manager.UpdateUser(user2);
			User userResult = manager.GetUser("s.chen@company.nl");


            Assert.AreEqual("33789987", userResult.PhoneNumber);
        }

		[TestMethod]
		public void UpdateUser_Email_Not_Exist_ShouldThrowException()
		{
			UserManager manager = new UserManager(new FakeUserRepo());
			User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
			User userUpdated = new User("Steven", "Chen", "s.wu@company.nl", new DateTime(1980, 3, 3), "33789987", "password");

			manager.AddUser(user1);

			Assert.ThrowsException<Exception>(() => manager.UpdateUser(userUpdated), "Cannot remove user");
		}


        [TestMethod]
        public void GetUserTest_Email_That_Exist()
        {
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");

            manager.AddUser(user1);

            Assert.IsNotNull(manager.GetUser("s.chen@company.nl"));
        }

        [TestMethod]
		public void GetUserTest_Email_Not_Exist_Should_Return_Null()
		{
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");

            manager.AddUser(user1);

			Assert.IsNull(manager.GetUser("s.wu@company.nl"));
        }

    }
}
