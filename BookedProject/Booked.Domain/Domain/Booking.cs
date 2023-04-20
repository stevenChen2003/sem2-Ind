using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public abstract class Booking
    {
        //Maybe exclude start date end date
        protected int BookingId { get; set; }
        protected User User { get; set; }
        protected DateTime StartDate { get; set; }
        protected DateTime EndDate { get; set; }
        protected decimal Price { get; set; }
        protected string Description { get; set; }
        protected DateTime BookingDate { get; set; }

        public Booking() { }

        //Without ID
        public Booking(User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate)
        {
            User = user;
            StartDate = startDate;
            EndDate = endDate;
            Price = 0;
            Description = description;
            BookingDate = bookingDate;
        }

        //With ID when getting from database
        public Booking(int id,User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate)
        {
            BookingId = id;
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
