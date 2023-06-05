using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookedProject.Mocks
{
	public class FakeUserRepo : IUserRepo
	{
		private List<User> users = new List<User>();

		public void AddUser(User user)
		{
			users.Add(user);
		}

		public User FindUserByEmail(string email)
		{
			foreach (var user in users)
			{
				if (user.Email == email) return user;
			}
			return null;
		}

        public User FindUserByid(int id)
        {
            foreach (var user in users)
            {
                if (user.UserId == id) return user;
            }
            return null;
        }

        public IEnumerable<User> GetAllUser()
		{
			return users;
		}

		public string GetHashedAndSaltPassword(string email)
		{
            User user = FindUserByEmail(email);
            if (user != null)
            {
                return user.Password;
            }
            return null;
        }

		public void RemoveUserByEmail(int id)
		{
            User userToRemove = FindUserByid(id);
            if (userToRemove != null)
            {
                users.Remove(userToRemove);
            }
            else
            {
                throw new Exception("Cannot remove user");
            }
        }

        public void UpdateUser(User user)
		{
            User userExist = FindUserByEmail(user.Email);
			if (userExist != null)
			{
                userExist.FirstName = user.FirstName;
                userExist.LastName = user.LastName;
                userExist.DateOfBirth = user.DateOfBirth;
                userExist.PhoneNumber = user.PhoneNumber;
            }
            else
            {
				throw new Exception("Cannot update user");
			}
        }

	}
}
