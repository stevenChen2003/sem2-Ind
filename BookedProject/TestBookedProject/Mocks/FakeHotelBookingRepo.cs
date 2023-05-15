using Booked.Domain.Domain;
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

		public IEnumerable<Booking> GetAllBookingByUserId(int userId)
		{
			throw new NotImplementedException();
		}

		public void RemoveBooking(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateBooking(HotelBooking booking)
		{
			throw new NotImplementedException();
		}
	}
}
