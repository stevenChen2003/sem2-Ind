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

        public bool CheckIfReviewExist(Review review)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetAllReviewBasedOnHotelId(int hotelId)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Review> GetAllReviewBasedOnUserdId(int userId)
		{
			throw new NotImplementedException();
		}

		public void RemoveReviewByID(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateReview(Review review)
		{
			throw new NotImplementedException();
		}
	}
}
