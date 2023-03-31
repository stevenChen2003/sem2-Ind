using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Konscious.Security.Cryptography;
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
            // Generate a random salt value
            byte[] salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            // Hash the password using Argon2
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.Iterations = 4;
            argon2.MemorySize = 1024 * 1024;
            argon2.DegreeOfParallelism = 4;
            var hashBytes = argon2.GetBytes(32);

            // Combine the salt and hash into a single string
            byte[] hashSaltBytes = new byte[16 + 32];
            Array.Copy(salt, 0, hashSaltBytes, 0, 16);
            Array.Copy(hashBytes, 0, hashSaltBytes, 16, 32);
            string hashSaltString = Convert.ToBase64String(hashSaltBytes);

            return hashSaltString;
        }

        public bool CheckPassword(string password, string email)
        {
            string hashSaltString = userRepo.GetHashedPasswordAndSalt(email);
            byte[] hashSaltBytes = Convert.FromBase64String(hashSaltString);
            byte[] salt = new byte[16];
            Array.Copy(hashSaltBytes, 0, salt, 0, 16);
            byte[] hashBytes = new byte[32];
            Array.Copy(hashSaltBytes, 16, hashBytes, 0, 32);

            // Hash the password using Argon2 with the same parameters as the EncryptPasswordArgon2 method
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password));
            argon2.Salt = salt;
            argon2.Iterations = 4;
            argon2.MemorySize = 1024 * 1024;
            argon2.DegreeOfParallelism = 4;
            var hashBytesTest = argon2.GetBytes(32);

            // Compare the resulting hash with the stored hash
            return hashBytes.SequenceEqual(hashBytesTest);
        }

    }
}
