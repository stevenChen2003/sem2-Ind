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
            return bookings.SingleOrDefault(b => b.BookingId == id);
        }

        public void RemoveBooking(int id)
		{
            try
            {
                var existingBooking = bookings.Find(booking => booking.BookingId == id);
                if (existingBooking == null)
                {
                    throw new Exception("Error");
                }
                else
                {
                    bookings.Remove(existingBooking);
                }
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

		public void UpdateBooking(Booking booking)
		{
            try
            {
                var existingBooking = bookings.FirstOrDefault(b => b.BookingId == booking.BookingId);
                if (existingBooking != null)
                {
                    existingBooking.Status = booking.Status;
                }
                else { throw new Exception(); }
            }
            catch (Exception) { throw new Exception("Error"); }
        }
	}
}
