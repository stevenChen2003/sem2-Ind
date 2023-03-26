using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
	public class Hotel
	{
		public Hotel() { }

		public Hotel(int id, string name, string address, string city, string country, int starRating, decimal pricePerNight)
		{
			HotelId = id;
			Name = name;
			Address = address;
			City = city;
			Country = country;
			StarRating = starRating;
			PricePerNight = pricePerNight;
		}

		public int HotelId { get; set; }
		public string Name { get; set; }
		public string Address { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public int StarRating { get; set; }
		public decimal PricePerNight { get; set; }

	}
}
