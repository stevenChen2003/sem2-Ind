using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public class Booking
    {
        public int BookingId { get; set; }
        public User User { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime BookingDate { get; set; }

        public Booking(User user, DateTime startDate, DateTime endDate, decimal price, string description, DateTime bookingDate)
        {
            User = user;
            StartDate = startDate;
            EndDate = endDate;
            Price = price;
            Description = description;
            BookingDate = bookingDate;
        }
    }
}
