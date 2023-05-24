using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookedProject.Mocks
{
	public class FakeBookingRepo : IBookingRepo
	{
		public void AddFlightBooking(FlightBooking booking)
		{
			throw new NotImplementedException();
		}

		public void AddHotelBooking(HotelBooking hotelBooking)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Booking> GetAllBooking()
		{
			throw new NotImplementedException();
		}

		public Booking GetBookingById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Booking> GetBookingByUserId(int userId)
		{
			throw new NotImplementedException();
		}

		public void RemoveBooking(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateBooking(Booking booking)
		{
			throw new NotImplementedException();
		}
	}
}
