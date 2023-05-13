using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
	public class Review
	{
		public int Id { get; set; }
		public User User { get; set; }
		public int HotelId { get; set; }
		public string Description { get; set; }
		public int Rating { get; set; }
		
		public Review() { }

        public Review(int id, User user, int hotelId, string description, int rating)
        {
			Id = id;
            User = user;
            HotelId = hotelId;
            Description = description;
            Rating = rating;
        }

        public Review(User user, int hotelId, string description, int rating)
		{
			User= user;
			HotelId= hotelId;
			Description= description;
			Rating= rating;
		}
    }
}
