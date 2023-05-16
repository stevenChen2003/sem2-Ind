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
			try
			{
                return hotelRepo.GetAllHotel();
            }
			catch
			{
				return null;
			}
		}

		public IEnumerable<Hotel> GetHotelsByCountry(string search, string sort, int itemsPerPage, int offset)
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
				return hotelRepo.GetAllHotelBySearchCount(search);
			}
			else
			{
				return hotelRepo.GetAllHotel().Count();
			}
		}

        public bool AddHotel(Hotel hotel)
		{
			try
			{
				if (!CheckIfHotelExist(hotel))
				{
                    hotelRepo.AddHotel(hotel);
					return true;
                }
				else
				{
					return false;
				}

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
