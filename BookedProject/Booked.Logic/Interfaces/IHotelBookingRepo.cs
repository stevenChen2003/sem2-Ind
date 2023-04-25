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
        bool AddBooking(Booking booking);
        Booking GetBookingById(int id);
        bool UpdateBooking(Booking booking);
        bool RemoveBooking(int id);
    }
}
