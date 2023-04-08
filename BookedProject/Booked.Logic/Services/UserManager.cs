using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Services
{
	public class UserManager
	{
		private UserRepository userRepo;

		public UserManager()
		{
			userRepo= new UserRepository();
		}

        public User GetUser(string email)
        {
            User foundUser = userRepo.FindUserByEmail(email);
            return foundUser;
        }

		public bool AddUser(User user)
		{
			if (userRepo.FindUserByEmail(user.Email) != null)
			{
				return false;
			}
			else
			{
                user.Password = HashPassword(user.Password);
                userRepo.AddUser(user);
				return true;
            }
		}

        public void UpdateUser(string email)
        {

        }

        public void DeleteUser(string email)
        {

        }



        //Make a seperate class for these
        public string HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public bool CheckPassword(string password, string email)
        {
            string hashedPassword = userRepo.GetHashedAndSaltPassword(email);
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }

    }
}
