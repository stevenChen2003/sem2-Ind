using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public class HotelBooking : Booking
    {
        public HotelBooking() { }

		public HotelBooking(User user, DateTime startDate, DateTime endDate, decimal price, string description, DateTime bookingDate) : base(user, startDate, endDate, price, description, bookingDate)
        {

        }
	}
}
