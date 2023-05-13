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
        private List<Review> reviews = new List<Review>();

        public void AddReview(Review review)
		{
			reviews.Add(review);
		}

        public List<Review> GetAllReviewBasedOnHotelId(int hotelId)
		{
			List<Review> found = new List<Review>();
			foreach (Review review in reviews)
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
            foreach (Review review in reviews)
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
			foreach (Review review in reviews)
			{
				if (review.Id == id)
				{
					reviews.Remove(review);
				}
			}
		}

		public void UpdateReview(Review review)
		{
            foreach (Review r in reviews)
            {
                if (r.Id == review.Id) review = r;
            }
        }
	}
}
