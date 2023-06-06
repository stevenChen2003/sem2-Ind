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

		public int GetAllHotelCount()
		{
			return hotelsList.Count();
		}

		public IEnumerable<Hotel> GetAllHotelPerPage(string sort, int itemsPerPage, int offset)
        {
            throw new NotImplementedException();
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

		public int GetHotelBySearchCount(string search)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Hotel> GetHotelPerPage(string search, string sort, int itemsPerPage, int offset)
        {
            throw new NotImplementedException();
        }

        public void RemoveHotelByID(int id)
		{
			try
			{
                Hotel hotel = GetHotelByID(id);
                if (hotel == null)
                {
                    throw new Exception("Error");
                }
				else
				{
                    hotelsList.Remove(hotel);
                }
            }
			catch (Exception)
			{
				throw new Exception();
			}
        }

		public void UpdateHotel(Hotel hotel)
		{
			try
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
				else { throw new Exception(); }
            }
			catch(Exception) { throw new Exception("Error"); }
        }
	}
}
