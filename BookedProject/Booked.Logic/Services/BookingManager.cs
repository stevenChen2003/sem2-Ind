using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Services
{
	public class BookingManager
	{
		private IBookingRepo bookingRepo;

		public BookingManager(IBookingRepo bookingRepo)
		{
			this.bookingRepo = bookingRepo;
		}

		public void AddBooking(Booking booking)
		{
			try
			{
				if (booking is HotelBooking)
				{
					bookingRepo.AddHotelBooking((HotelBooking)booking);
				}
				else if (booking is FlightBooking)
				{
					bookingRepo.AddFlightBooking((FlightBooking)booking);
				}
			}
			catch (Exception ex)
			{
				throw new InvalidOperationException("Error making booking", ex);
			}
		}

		//Get
		public IEnumerable<Booking> GetAllBookingByUserId(int usedId)
		{
			try
			{
				return bookingRepo.GetBookingByUserId(usedId);
            }
			catch (Exception)
			{
				throw new InvalidOperationException("No booking found");
			}
		}

		//Update
		public void UpdateBooking(Booking booking)
		{
			try
			{
				bookingRepo.UpdateBooking(booking);
			}
			catch (Exception)
			{
				throw new InvalidOperationException("Booking cannot be cancelled");
			}
		}

		//Delete
		public void DeleteBooking(Booking booking)
		{
			try
			{
				bookingRepo.RemoveBooking(booking.BookingId);
			}
			catch (Exception)
			{
				throw new InvalidOperationException("Booking cannot be deleted");
			}
		}

		//Get the Booking details
		public Booking GetBookingByid(int id)
		{
			try
			{
				return bookingRepo.GetBookingById(id);
			}
			catch (Exception)
			{
				throw new InvalidOperationException("Booking not found");
			}
		}


		//Popular booking
        public List<int> GetPopularHotelBookings()
        {
            Dictionary<int, int> hotelIdAndCount = new Dictionary<int, int>();

            List<HotelBooking> hotelBookings = new List<HotelBooking>();
            foreach (var b in bookingRepo.GetAllBooking())
            {
                if (b is HotelBooking)
                {
                    hotelBookings.Add((HotelBooking)b);
                }
            }

            foreach (var h in hotelBookings)
            {
                if (hotelIdAndCount.ContainsKey(h.Hotel.HotelId))
                {
                    hotelIdAndCount[h.Hotel.HotelId] += 1;
                }
                else
                {
                    hotelIdAndCount.Add(h.Hotel.HotelId, 1);
                }
            }

            int[] topThreeKeys = hotelIdAndCount.OrderByDescending(x => x.Value).Take(3).Select(x => x.Key).ToArray();
            return topThreeKeys.ToList();
        }


    }
}
