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
		private IHotelBookingRepo hotelBookingRepo;
		private IFlightBookingRepo flightBookingRepo;

		public BookingManager(IHotelBookingRepo hotelBookingRepo, IFlightBookingRepo flightBookingRepo)
		{
			this.hotelBookingRepo = hotelBookingRepo;
			this.flightBookingRepo = flightBookingRepo;
		}

		public bool AddBooking(Booking booking)
		{
			if (booking is HotelBooking)
			{
				hotelBookingRepo.AddBooking((HotelBooking)booking);
				return true;
			}
			else if (booking is FlightBooking)
			{
				flightBookingRepo.AddBooking((FlightBooking)booking);
				return true;
			}
			return false;
		}

		//Get



		//Update


		//Delet
	}
}
