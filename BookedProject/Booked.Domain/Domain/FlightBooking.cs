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

		public FlightBooking(User user, DateTime startDate, DateTime endDate, DateTime bookingDate, Flight flight, bool extra) : base(user, startDate, endDate, bookingDate)
		{
            Flight = flight;
            ExtraLuggage = extra;
        }

        public FlightBooking(int id,User user, DateTime startDate, DateTime endDate, DateTime bookingDate, Flight flight, bool extra, string status) : base(id, user, startDate, endDate, bookingDate, status)
        {
            Flight = flight;
            ExtraLuggage = extra;
        }

        public override decimal GetPrice()
        {
            if (ExtraLuggage)
            {
                return Price = Flight.Price + Flight.ExtraBaggagePrice;
            }
            return Price = Flight.Price;
        }

    }
}
