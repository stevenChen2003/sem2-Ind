using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
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
                userRepo.AddUser(user);
				return true;
            }
		}

		//Need to make the hash method
		public string HashPassword(string password)
		{
			return "";
		}


    }
}
