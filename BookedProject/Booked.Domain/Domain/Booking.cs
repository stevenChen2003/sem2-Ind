using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public abstract class Booking
    {
        public int BookingId { get; set; }
        public User User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime BookingDate { get; set; }

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
