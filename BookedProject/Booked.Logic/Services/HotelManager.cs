using Booked.Domain.Domain;
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
		private HotelDAL hotelDAL;

		public HotelManager()
		{
			hotelDAL = new HotelDAL();
		}

		public Hotel GetHotel(int id)
		{
			return hotelDAL.GetHotelByID(id);
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			return hotelDAL.GetAllHotel();
		}
	}
}
