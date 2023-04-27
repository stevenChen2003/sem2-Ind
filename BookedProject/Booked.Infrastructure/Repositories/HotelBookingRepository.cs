using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
    public class HotelBookingRepository : IHotelBookingRepo
    {

        public IEnumerable<Booking> GetAllBooking()
        {
            throw new NotImplementedException();
        }


        public Booking GetBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddBooking(HotelBooking b)
        {

        }

        public bool RemoveBooking(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBooking(HotelBooking booking)
        {
            throw new NotImplementedException();
        }


    }
}
