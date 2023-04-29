using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Services
{
    public class HotelBookingManager
    {
        private IHotelBookingRepo hotelBookingRepo;

        public HotelBookingManager(IHotelBookingRepo repo)
        {
            hotelBookingRepo = repo;
        }

        public void AddBooking(HotelBooking hotelBooking)
        {
            hotelBooking.GetPrice();
            hotelBookingRepo.AddBooking(hotelBooking);
        }

        public bool CheckAvailabe(HotelBooking hotelBooking)
        {
            if(hotelBooking.Hotel.MaximumBooking < 1)
            {
                return false;
            }
            return true;
        }


    }
}
