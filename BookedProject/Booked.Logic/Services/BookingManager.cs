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
			catch (Exception ex)
			{
				throw new Exception("Not working");
			}
		}

		//Update
		public bool UpdateBooking(Booking booking)
		{
			try
			{
				bookingRepo.UpdateBooking(booking);
				return true;
			}
			catch
			{
				return false;
			}
		}

		//Delete
		public bool DeleteBooking(Booking booking)
		{
			try
			{
				bookingRepo.RemoveBooking(booking.BookingId);
				return true;
			}
			catch
			{
				return false;
			}
		}

		//Get the Booking details
		public Booking GetBookingByid(int id)
		{
			try
			{
				return bookingRepo.GetBookingById(id);
			}
			catch
			{
				return null;
			}
		}

	}
}
