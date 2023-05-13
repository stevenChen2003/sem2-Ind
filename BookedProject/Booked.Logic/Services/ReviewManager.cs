using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Services
{
	public class ReviewManager
	{
		private IReviewRepo reviewRepo;

		public ReviewManager(IReviewRepo _reviewRepo)
		{
			this.reviewRepo = _reviewRepo;
		}

		//Add
		public bool AddReview(Review review)
		{
            try
            {
                if (!CheckIfReviewExist(review))
                {
                    reviewRepo.AddReview(review);
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception)
            {
                throw new Exception("Adding not succesfull");
            }
        }

		//Check if user has review on the hotel
		public bool CheckIfReviewExist(Review review)
		{
			foreach (Review r in reviewRepo.GetAllReviewBasedOnHotelId(review.HotelId))
			{
				if(r.HotelId == review.HotelId && r.User.UserId == review.User.UserId)
				{
					return true;
				}
			}
			return false;
		}

		//Get

		//Update

		//Delete
		
	}
}
