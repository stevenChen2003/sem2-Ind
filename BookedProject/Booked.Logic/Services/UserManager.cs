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
				user.Password = EncryptPassword(user.Password);
                userRepo.AddUser(user);
				return true;
            }
		}

		public string EncryptPassword(string password)
		{
			byte[] salt = GenerateSalt(16);
            var hashedPassword = new Rfc2898DeriveBytes(password, salt, 10_000).GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hashedPassword, 0, hashBytes, 16, 20);
            string hashedPasswordBase64 = Convert.ToBase64String(hashBytes);

            return hashedPasswordBase64;
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
            string hashedPassword = userRepo.GetHashedPassword(email);

            byte[] hashBytes = Convert.FromBase64String(hashedPassword);
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 10_000);
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
