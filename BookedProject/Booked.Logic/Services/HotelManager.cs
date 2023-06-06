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
		private IReviewRepo reviewerRepo;

		public HotelManager(IHotelRepo repo)
		{
			hotelRepo = repo;
		}

		public HotelManager(IHotelRepo hotelRepo, IReviewRepo reviewRepo)
		{
			this.hotelRepo = hotelRepo;
			this.reviewerRepo = reviewRepo;
		}

		public Hotel GetHotel(int id)
		{
			return hotelRepo.GetHotelByID(id);
		}

		public Hotel GetHotelWithReviews(int id)
		{
			Hotel hotel = hotelRepo.GetHotelByID(id);
			hotel.Reviews = reviewerRepo.GetAllReviewBasedOnHotelId(id);
			return hotel;
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			try
			{
                return hotelRepo.GetAllHotel();
            }
			catch (Exception)
			{
				throw new Exception("No hotels found");
			}
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
			try
			{
				hotelRepo.UpdateHotel(hotel);
			}
			catch(Exception ex)
			{
				throw new Exception("Cannot update hotel information", ex);
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
