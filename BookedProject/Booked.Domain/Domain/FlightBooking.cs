using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public class FlightBooking : Booking
    {
        public Flight Flight { get; set; }
        public bool ExtraLuggage { get; set; }


		public FlightBooking()
		{
		}

		public FlightBooking(User user, DateTime startDate, DateTime endDate, decimal price, string description, DateTime bookingDate) : base(user, startDate, endDate, price, description, bookingDate)
		{

        }

	}
}
