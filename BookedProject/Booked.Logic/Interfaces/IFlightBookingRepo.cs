using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
	public interface IFlightBookingRepo
	{
		IEnumerable<Booking> GetAllBooking();
		IEnumerable<Booking> GetBookingByUserId(int userId);
		FlightBooking GetBookingById(int id);
		void AddBooking(FlightBooking booking);
		bool UpdateBooking(FlightBooking booking);
		bool RemoveBooking(int id);
	}
}
