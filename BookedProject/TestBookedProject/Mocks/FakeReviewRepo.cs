using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookedProject.Mocks
{
	public class FakeReviewRepo : IReviewRepo
	{
        private List<Review> reviewslist = new List<Review>();

        public void AddReview(Review review)
		{
			reviewslist.Add(review);
		}

        public List<Review> GetAllReviewBasedOnHotelId(int hotelId)
		{
			List<Review> found = new List<Review>();
			foreach (Review review in reviewslist)
			{
				if (review.HotelId == hotelId)
				{
					found.Add(review);
				}
			}
			return found;
		}

		public List<Review> GetAllReviewBasedOnUserdId(int userId)
		{
            List<Review> found = new List<Review>();
            foreach (Review review in reviewslist)
            {
                if (review.User.UserId == userId)
                {
                    found.Add(review);
                }
            }
			return found;
        }

		public void RemoveReviewByID(int id)
		{
			foreach (Review review in reviewslist)
			{
				if (review.Id == id)
				{
					reviewslist.Remove(review);
				}
			}
		}

		public void UpdateReview(Review review)
		{
            var oldReview = reviewslist.FirstOrDefault(r => r.Id == review.Id);
            if (oldReview != null)
            {
                oldReview.Description = review.Description;
            }
        }
	}
}
