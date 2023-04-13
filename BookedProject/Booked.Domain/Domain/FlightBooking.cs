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
		public DateTime DepartureTime { get; set; }
		public DateTime ArrivalTime { get; set; }
        public bool ExtraLuggage { get; set; }


		public FlightBooking()
		{
		}

		public FlightBooking(User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate, Flight flight) : base(user, startDate, endDate, description, bookingDate)
		{

        }

        public override decimal GetPrice()
        {
            return Price +  Flight.Price;
        }

    }
}
