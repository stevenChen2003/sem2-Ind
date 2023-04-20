using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Services
{
	public class HotelManager
	{
		private HotelRepository hotelRepo;

		/// <summary>
		/// Change to DI later
		/// </summary>
		public HotelManager()
		{
			hotelRepo = new HotelRepository();
		}

		public Hotel GetHotel(int id)
		{
			return hotelRepo.GetHotelByID(id);
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			return hotelRepo.GetAllHotel();
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

	}
}
