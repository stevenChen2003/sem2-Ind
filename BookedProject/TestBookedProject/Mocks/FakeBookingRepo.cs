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
		private List<Booking> bookings;

		public FakeBookingRepo()
		{
			bookings = new List<Booking>();
		}

		public void AddFlightBooking(FlightBooking booking)
		{
			bookings.Add(booking);
		}

		public void AddHotelBooking(HotelBooking hotelBooking)
		{
			bookings.Add(hotelBooking);
		}

		public IEnumerable<Booking> GetAllBooking()
		{
			return bookings;
		}

		public IEnumerable<Booking> GetBookingByUserId(int userId)
		{
			return bookings.Where(b => b.User.UserId == userId);
		}

		public Booking GetBookingById(int id)
		{
			return bookings.FirstOrDefault(b => b.BookingId == id);
		}

		public void RemoveBooking(int id)
		{
			bookings.RemoveAll(b => b.BookingId == id);
		}

		public void UpdateBooking(Booking booking)
		{
			// No implementation needed for fake repository
		}
	}
}
