using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
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

		public bool AddUser(User user)
		{
			if (userRepo.FindUserByEmail(user.Email) != null)
			{
				return false;
			}
			else
			{
                string salt = EncryptPassword(user.Password)[0];
                user.Password = EncryptPassword(user.Password)[1];
                userRepo.AddUser(user, salt);
				return true;
            }
		}

		public string[] EncryptPassword(string password)
		{
			byte[] salt = GenerateSalt(16);
            var hashedPassword = new Rfc2898DeriveBytes(password, salt, 10_000).GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hashedPassword, 0, hashBytes, 16, 20);
            string saltString = Convert.ToBase64String(salt);
            string hashedPasswordString = Convert.ToBase64String(hashBytes);

            return new string[] { saltString, hashedPasswordString };
        }

        public byte[] GenerateSalt(int saltLength)
        {
            byte[] salt = new byte[saltLength];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }
            return salt;
        }

        public bool CheckPassword(string password, string email)
        {
            string[] hashedPasswordAndSalt = userRepo.GetHashedPasswordAndSalt(email);
            string hashedPassword = hashedPasswordAndSalt[0];
            string salt = hashedPasswordAndSalt[1];

            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] saltBytes = Convert.FromBase64String(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10_000);
            byte[] hash = pbkdf2.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] != hash[i])
                {
                    return false;
                }
            }
            return true;
        }

    }
}
