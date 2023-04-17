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
        public Rooms Room { get; set; }
        public int MaximumBooking { get; set; }
        public byte[] Image { get; set; }
        public List<Review> Reviews { get; set; }

        public Hotel() { }

        //With ID
        public Hotel(int id, string name, string address, string city, string country, int starRating, decimal pricePerNight, Rooms room, int maximumBooking, byte[] image)
        {
            HotelId = id;
            Name = name;
            Address = address;
            City = city;
            Country = country;
            StarRating = starRating;
            PricePerNight = pricePerNight;
            Room = room;
            MaximumBooking = maximumBooking;
            Image = image;
        }

        //Need to include room and maximumbooking
        //Without ID
        public Hotel(string name, string address, string city, string country, int starRating, decimal pricePerNight, Rooms room, int maximumBooking, byte[] image)
        {
            Name = name;
            Address = address;
            City = city;
            Country = country;
            StarRating = starRating;
            PricePerNight = pricePerNight;
            Room = room;
            MaximumBooking = maximumBooking;
            Image = image;
        }

        

        public void AddReview(Review review)
        {
            Reviews.Add(review);
        }
	}
}
