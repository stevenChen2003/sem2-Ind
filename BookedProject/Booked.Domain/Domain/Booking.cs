using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public abstract class Booking
    {
        //Maybe include a booking date
        protected int BookingId { get; set; }
        protected User User { get; set; }
        protected DateTime StartDate { get; set; }
        protected DateTime EndDate { get; set; }
        protected decimal Price { get; set; }
        protected string Description { get; set; }
        protected DateTime BookingDate { get; set; }

        public Booking() { }

        public Booking(User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate)
        {
            User = user;
            StartDate = startDate;
            EndDate = endDate;
            Price = 0;
            Description = description;
            BookingDate = bookingDate;
        }

        public virtual decimal GetPrice() { return Price; }


    }
}
