﻿using Booked.Domain.Domain;
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
			throw new NotImplementedException();
		}

		public User FindUserByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetAllUser()
		{
			throw new NotImplementedException();
		}

		public string GetHashedAndSaltPassword(string email)
		{
			throw new NotImplementedException();
		}

		public void RemoveUserByEmail(string email)
		{
			throw new NotImplementedException();
		}

		public void UpdateUser(User user)
		{
			throw new NotImplementedException();
		}
	}
}
