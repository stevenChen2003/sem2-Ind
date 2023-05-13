using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
    public interface IHotelBookingRepo
    {
        IEnumerable<Booking> GetAllBooking();
        IEnumerable<Booking> GetAllBookingByUserId(int userId);
        HotelBooking GetBookingById(int id);
        void AddBooking(HotelBooking booking);
        bool UpdateBooking(HotelBooking booking);
        bool RemoveBooking(int id);
    }
}
