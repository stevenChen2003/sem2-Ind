using Booked.Domain.Domain;
using BCrypt.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Booked.Logic.Interfaces;
using Booked.Logic.Exceptions;

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

        public IEnumerable<User> GetAllUsers()
        {
            try
            {
				return userRepo.GetAllUser();
			}
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }


		public void AddUser(User user)
		{
            if (userRepo.FindUserByEmail(user.Email) != null)
            {
                throw new EmailExistException("Email exist");
            }
            else
            {
                user.Password = HashPassword(user.Password);
                userRepo.AddUser(user);
            }
        }

        public void UpdateUser(User user)
        {
            try
            {
                userRepo.UpdateUser(user);
            }
            catch (Exception)
            {
                throw new Exception ("Error in updating, please try again");
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                userRepo.RemoveUserByEmail(id);
            }
            catch (Exception)
			{
				throw new Exception("Error in deleting account, please try again");
			}
        }

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
            catch (Exception)
            {
                return false;
            }
        }

    }
}
