﻿using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookedProject.Mocks
{
	public class FakeHotelBookingRepo : IHotelBookingRepo
	{
		public void AddBooking(HotelBooking booking)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Booking> GetAllBooking()
		{
			throw new NotImplementedException();
		}

		public HotelBooking GetBookingById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Booking> GetBookingByUserId(int userId)
		{
			throw new NotImplementedException();
		}

		public bool RemoveBooking(int id)
		{
			throw new NotImplementedException();
		}

		public bool UpdateBooking(HotelBooking booking)
		{
			throw new NotImplementedException();
		}
	}
}
