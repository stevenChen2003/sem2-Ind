using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
    public class HotelBooking : Booking
    {
        public Hotel Hotel { get; set; }
        public int AmountOfDays { get; set; }

        //Without id
		public HotelBooking(User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate, Hotel hotel) : base(user, startDate, endDate, description, bookingDate)
        {
            Hotel= hotel;
            AmountOfDays = (EndDate.Date - StartDate.Date).Days;
        }

        //With ID
        public HotelBooking(int id, User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate, Hotel hotel) : base(id, user, startDate, endDate, description, bookingDate)
        {
            Hotel= hotel;
            AmountOfDays = (EndDate.Date - StartDate.Date).Days;
        }

        public override decimal GetPrice()
        {
            Price = AmountOfDays * Hotel.PricePerNight;
            return Price;
        }
    }
}
