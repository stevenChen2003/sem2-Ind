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
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }


        //Without ID
        public Booking(User user, DateTime startDate, DateTime endDate, DateTime bookingDate)
        {
            User = user;
            StartDate = startDate;
            EndDate = endDate;
            Price = 0;
            BookingDate = bookingDate;
        }

        //With ID
        public Booking(int id,User user, DateTime startDate, DateTime endDate, DateTime bookingDate, string status)
        {
            BookingId = id;
            User = user;
            StartDate = startDate;
            EndDate = endDate;
            Price = 0;
            BookingDate = bookingDate;
            Status = status;
        }

        public virtual decimal GetPrice() { return Price; }


    }
}
