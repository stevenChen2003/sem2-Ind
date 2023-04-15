using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
	public class Review
	{
		public int UserId { get; set; }
		public int HotelId { get; set; }
		public string Description { get; set; }
		public int Rating { get; set; }
		
		public Review() { }

		public Review(int userId, int hotelId, string description, int rating)
		{
			UserId= userId;
			HotelId= hotelId;
			Description= description;
			Rating= rating;
		}
    }
}
