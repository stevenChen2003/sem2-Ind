using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Services
{
	public class HotelManager
	{
		private IHotelRepo hotelRepo;

		public HotelManager(IHotelRepo repo)
		{
			hotelRepo = repo;
		}

		public Hotel GetHotel(int id)
		{
			return hotelRepo.GetHotelByID(id);
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			return hotelRepo.GetAllHotel();
		}

		public IEnumerable<Hotel> GetHotelsByCountry(string search)
		{
			if (string.IsNullOrEmpty(search))
			{
                return null;
            }

            if (hotelRepo.GetAllHotelBySearch(search) == null)
			{
				return null;
			}
			else
			{
                return hotelRepo.GetAllHotelBySearch(search);
            }
		}


        public void AddHotel(string name, string address, string city, string country, int starRating, decimal pricePerNight, Rooms roomType, int maximumBooking, byte[] image)
		{
			try
			{
				Hotel hotel = new Hotel(name, address, city, country, starRating, pricePerNight, roomType, maximumBooking, image);
				hotelRepo.AddHotel(hotel);

			}
			catch(Exception)
			{
				throw new Exception("Adding not succesfull");
			}
        }

		public void UpdateHotel(Hotel hotel)
		{
			try
			{
				hotelRepo.UpdateHotel(hotel);
			}
			catch(Exception)
			{
				throw new Exception("Cannot update hotel information");
			}
		}


		public void RemoveHotel(int id)
		{
			try
			{
				hotelRepo.RemoveHotelByID(id);
			}
			catch(Exception)
			{
				throw new Exception("Cannot remove hotel");
			}
		}

	}
}
