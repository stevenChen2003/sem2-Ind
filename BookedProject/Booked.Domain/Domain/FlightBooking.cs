using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public class FlightBooking : Booking
    {
        //Dont know if departureTime and ArrivalTime is need
        public Flight Flight { get; set; }
		public DateTime DepartureTime { get; set; }
		public DateTime ArrivalTime { get; set; }
        public bool ExtraLuggage { get; set; }

		public FlightBooking(User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate, Flight flight, bool extra) : base(user, startDate, endDate, description, bookingDate)
		{
            Flight= flight;
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
