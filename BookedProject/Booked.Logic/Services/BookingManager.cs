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
			if (booking is HotelBooking)
			{
				bookingRepo.AddHotelBooking((HotelBooking)booking);
			}
			else if (booking is FlightBooking)
			{
				bookingRepo.AddFlightBooking((FlightBooking)booking);
			}
		}

		//Get forms/admin
		public IEnumerable<Booking> GetAllBooking()
		{
			return bookingRepo.GetAllBooking();
		}

		public IEnumerable<Booking> GetAllBookingByUserId(int usedId)
		{
			return bookingRepo.GetBookingByUserId(usedId);
		}

		//Update
		public void UpdateBooking(Booking booking)
		{
			bookingRepo.UpdateBooking(booking);
		}

		//Delete
		public void DeleteBooking(int bookingID)
		{
			bookingRepo.RemoveBooking(bookingID);
		}

		//Get the Booking details
		public Booking GetBookingByid(int id)
		{
			return bookingRepo.GetBookingById(id);
		}


    }
}
