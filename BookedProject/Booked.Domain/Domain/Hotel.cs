using Booked.Domain.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
	public class Hotel
	{
        public int HotelId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int StarRating { get; set; }
        public decimal PricePerNight { get; set; }
		public byte[] Image { get; set; }
		public Rooms Room { get; set; }
		public List<Review> Reviews { get; set; }

        public Hotel() { }

        public Hotel(string name, string address, string city, string country, int starRating, decimal pricePerNight, byte[] image)
        {
            Name = name;
            Address = address;
            City = city;
            Country = country;
            StarRating = starRating;
            PricePerNight = pricePerNight;
            Image = image;
        }


        //Need fixing
        public Hotel(int id, string name, string address, string city, string country, int starRating, decimal pricePerNight, byte[] image)
		{
			HotelId = id;
			Name = name;
			Address = address;
			City = city;
			Country = country;
			StarRating = starRating;
			PricePerNight = pricePerNight;
            Image = image;
		}


	}
}
