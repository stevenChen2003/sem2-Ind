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

		public IEnumerable<User> GetAllUser()
		{
			return users;
		}

		public string GetHashedAndSaltPassword(string email)
		{
			foreach(var user in users)
			{
                if (user.Email == email) return user.Password;
            }
			return string.Empty;
		}

		public void RemoveUserByEmail(string email)
		{
			foreach (User user in users)
			{
				if (user.Email == email) users.Remove(user);
			}
		}

		public void UpdateUser(User user)
		{
            foreach (User u in users)
            {
                if (u.UserId == user.UserId) user = u;
            }
        }
	}
}
