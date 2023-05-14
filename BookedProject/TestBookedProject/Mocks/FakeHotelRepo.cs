using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookedProject.Mocks
{
	public class FakeHotelRepo : IHotelRepo
	{
		private List<Hotel> hotelsList = new List<Hotel>();

		public void AddHotel(Hotel hotel)
		{
			hotelsList.Add(hotel);
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			return hotelsList;
		}

		public IEnumerable<Hotel> GetAllHotelBySearch(string search, string sort)
		{
            var filteredHotels = hotelsList.Where(h => h.Country.StartsWith(search));

            IOrderedEnumerable<Hotel> sortedHotels;
            switch (sort)
            {
                case "name_desc":
                    sortedHotels = filteredHotels.OrderByDescending(h => h.Name);
                    break;
                case "price_asc":
                    sortedHotels = filteredHotels.OrderBy(h => h.PricePerNight);
                    break;
                case "price_desc":
                    sortedHotels = filteredHotels.OrderByDescending(h => h.PricePerNight);
                    break;
                default:
                    sortedHotels = filteredHotels.OrderBy(h => h.Name);
                    break;
            }

            return sortedHotels;
        }

		public Hotel GetHotelByID(int id)
		{
			foreach (var hotel in hotelsList)
			{
				if (hotel.HotelId == id)
				{
					return hotel;
				}
			}
			return null;
		}

		public void RemoveHotelByID(int id)
		{
            Hotel hotel = GetHotelByID(id);
            if (hotel != null)
            {
                hotelsList.Remove(hotel);
            }
        }

		public void UpdateHotel(Hotel hotel)
		{
            var existingHotel = hotelsList.FirstOrDefault(h => h.HotelId == hotel.HotelId);
            if (existingHotel != null)
            {
                existingHotel.Name = hotel.Name;
                existingHotel.Address = hotel.Address;
                existingHotel.City = hotel.City;
                existingHotel.Country = hotel.Country;
                existingHotel.StarRating = hotel.StarRating;
                existingHotel.PricePerNight = hotel.PricePerNight;
                existingHotel.Room = hotel.Room;
                existingHotel.MaximumBooking = hotel.MaximumBooking;
                existingHotel.Image = hotel.Image;
            }
        }
	}
}
