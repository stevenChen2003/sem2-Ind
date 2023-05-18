using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
	public interface IBookingRepo
	{
		IEnumerable<Booking> GetAllBooking();
		IEnumerable<Booking> GetBookingByUserId(int userId);
		Booking GetBookingById(int id);
		void AddHotelBooking(HotelBooking hotelBooking);
		void AddFlightBooking(FlightBooking booking);
		void UpdateBooking(Booking booking);
		void RemoveBooking(int id);
	}
}
