using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Exceptions;
using Booked.Logic.Interfaces;
using System;
using System.Collections;
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

		public IEnumerable<Hotel> GetHotelBySearch(string search, string sort, int itemsPerPage, int offset)
		{
            if (string.IsNullOrEmpty(search))
			{
                return hotelRepo.GetAllHotelPerPage(sort, itemsPerPage, offset);
            }
			else
			{
				search = search.Substring(0, 1).ToUpper() + search.Substring(1).ToLower();
                return hotelRepo.GetHotelPerPage(search, sort, itemsPerPage, offset);
            }
		}

		public int GetTotalHotelCount(string search)
		{
			if (!string.IsNullOrEmpty(search))
			{
				return hotelRepo.GetHotelBySearchCount(search);
			}
			else
			{
				return hotelRepo.GetAllHotelCount();
			}
		}

        public void AddHotel(Hotel hotel)
		{
            if (CheckIfHotelExist(hotel))
            {
                throw new HotelExistException("Hotel already exist");
            }
            else
            {
                hotelRepo.AddHotel(hotel);
            }
        }

		public void UpdateHotel(Hotel hotel)
		{
            hotelRepo.UpdateHotel(hotel);
        }


		public void RemoveHotel(int id)
		{
			hotelRepo.RemoveHotelByID(id);
		}

        public bool CheckIfHotelExist(Hotel hotel)
        {
            foreach (Hotel h in hotelRepo.GetAllHotel())
            {
                if (hotel.Name == h.Name && hotel.Address == h.Address && hotel.City == h.City && hotel.Country == h.Country && hotel.Room == h.Room)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
