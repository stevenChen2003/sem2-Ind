using Booked.Domain.Domain;
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

			bool result = manager.AddUser(user);

			Assert.IsTrue(result);
		}

		[TestMethod]
		public void AddDuplicateSameEmailUserTest()
		{
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            User user2 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            User user3 = new User("Steve", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            
			manager.AddUser(user1);
			bool result = manager.AddUser(user2);
            bool result2 = manager.AddUser(user3);

			Assert.IsFalse(result);
            Assert.IsTrue(result2);
        }

		[TestMethod]
		public void RemoveUserTest()
		{
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password");
            User user3 = new User("Steve", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password");


            manager.AddUser(user1);
			manager.AddUser(user3);
			bool result = manager.DeleteUser(user1.Email);

			Assert.IsTrue(result);
        }

		[TestMethod]
		public void UpdateUserTest()
		{
            UserManager manager = new UserManager(new FakeUserRepo());
            User user1 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password"); 
			User user2 = new User("Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 3, 3), "33789987", "password");

            bool result = manager.UpdateUser(user1);

			Assert.IsTrue(result);
        }


	}
}
