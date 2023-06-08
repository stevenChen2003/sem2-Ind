using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
    public interface IHotelRepo
    {
        Hotel GetHotelByID(int id);
        IEnumerable<Hotel> GetAllHotel();
        void AddHotel(Hotel hotel);
        void UpdateHotel(Hotel hotel);
        void RemoveHotelByID(int id);
        int GetAllHotelCount();
        int GetHotelBySearchCount(string search);
        IEnumerable<Hotel> GetAllHotelPerPage(string sort, int itemsPerPage, int offset);
		IEnumerable<Hotel> GetHotelPerPage(string search, string sort, int itemsPerPage, int offset);
	}
}
