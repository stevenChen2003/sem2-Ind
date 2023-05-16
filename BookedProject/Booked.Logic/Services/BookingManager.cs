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
		public IEnumerable<Booking> GetAllBookingByUserId(int usedId)
		{
			try
			{
				if (flightBookingRepo.GetBookingByUserId(usedId) != null && hotelBookingRepo.GetAllBookingByUserId(usedId) != null)
				{
					return hotelBookingRepo.GetAllBookingByUserId(usedId).Concat(flightBookingRepo.GetBookingByUserId(usedId));
				}
				else if (flightBookingRepo.GetBookingByUserId(usedId) != null && hotelBookingRepo.GetAllBookingByUserId(usedId) == null)
				{
					return flightBookingRepo.GetBookingByUserId(usedId);

                }
				else if (flightBookingRepo.GetBookingByUserId(usedId) == null && hotelBookingRepo.GetAllBookingByUserId(usedId) != null)
				{
					return hotelBookingRepo.GetAllBookingByUserId(usedId);

                }
                else
				{
					return null;
				}

            }
			catch (Exception ex)
			{
				throw new Exception("Not working");
			}
		}


		//Update


		//Delete
	}
}
