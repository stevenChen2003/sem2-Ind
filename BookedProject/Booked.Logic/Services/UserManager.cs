using Booked.Domain.Domain;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Booked.Logic.Interfaces;

namespace Booked.Logic.Services
{
	public class UserManager
	{
        private IUserRepo userRepo;

        public UserManager(IUserRepo repo)
        {
            userRepo = repo;
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

        public bool UpdateUser(User user)
        {
            try
            {
                userRepo.UpdateUser(user);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteUser(string email)
        {
            try
            {
                userRepo.RemoveUserByEmail(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Gonna move this to another class, maybe
        public string HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public bool CheckPassword(string password, string email)
        {
            try
            {
                string hashedPassword = userRepo.GetHashedAndSaltPassword(email);
                return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
