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
        public List<decimal> ExtraService { get; set; }

		public HotelBooking(User user, DateTime startDate, DateTime endDate, string description, DateTime bookingDate, Hotel hotel) : base(user, startDate, endDate, description, bookingDate)
        {
            Hotel= hotel;
        }

        public override decimal GetPrice()
        {
            int amount = (EndDate.Date - StartDate.Date).Days;
            Price = amount * Hotel.PricePerNight;
            //Extra item maybe for services?
            /*
            foreach (var item in ExtraService)
            {
                Price += item;
            }
            */
            return Price;
        }
    }
}
