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
		private HotelRepository hotelrepo;

		public HotelManager()
		{
			hotelrepo = new HotelRepository();
		}

		public Hotel GetHotel(int id)
		{
			return hotelrepo.GetHotelByID(id);
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			return hotelrepo.GetAllHotel();
		}
	}
}
