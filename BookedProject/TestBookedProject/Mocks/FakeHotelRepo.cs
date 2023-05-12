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
		private List<Hotel> hotels = new List<Hotel>();

		public void AddHotel(Hotel hotel)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Hotel> GetAllHotelBySearch(string search, string sort)
		{
			throw new NotImplementedException();
		}

		public Hotel GetHotelByID(int id)
		{
			throw new NotImplementedException();
		}

		public void RemoveHotelByID(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateHotel(Hotel hotel)
		{
			throw new NotImplementedException();
		}
	}
}
