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
    }
}
