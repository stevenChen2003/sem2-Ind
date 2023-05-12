using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
	public interface IReviewRepo
	{
		IEnumerable<Review> GetAllReviewBasedOnHotelId(int hotelId);
		IEnumerable<Review> GetAllReviewBasedOnUserdId(int userId);
		void AddReview(Review review);
		void UpdateReview(Review review);
		void RemoveReviewByID(int id);
	}
}
