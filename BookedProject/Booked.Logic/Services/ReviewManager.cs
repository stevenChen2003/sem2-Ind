using Booked.Domain.Domain;
using Booked.Logic.Exceptions;
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
		public void AddReview(Review review)
		{
            try
            {
                if (CheckIfReviewExist(review))
                {
					throw new AlreadyExistException("User already has review");
                }
				else
				{
					reviewRepo.AddReview(review);
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
		public List<Review> GetReviewsBaseOnHotelId(int hotelid)
		{
			try
			{
				 return reviewRepo.GetAllReviewBasedOnHotelId(hotelid);
			}
			catch (Exception)
			{
                return null;
            }
		}

        public Review GetReviewById(int id)
        {
            try
            {
                return reviewRepo.GetReview(id);
            }
            catch (Exception)
            {
                return null;
            }
        }

        //Update
        public void UpdateReview(Review review)
        {
            reviewRepo.UpdateReview(review);
        }

        //Delete
        public void DeleteReview(int id)
        {
            reviewRepo.RemoveReviewByID(id);
        }


		//Calculate hotel rating
		public float GetAvgRating(int id)
		{
			List<Review> reviews = GetReviewsBaseOnHotelId(id);

			if (reviews.Count == 0)
			{
				return 0;
			}

			float rating = 0;

			foreach (Review review in reviews)
			{
				rating += review.Rating;
			}

			float avgRating = (float)Math.Round(rating / reviews.Count, 1);
			return avgRating;
		}

		//Statistics for each rating 
		public int[] GetSummaryRating(int hotelid)
		{
			List<Review> reviews = GetReviewsBaseOnHotelId(hotelid);
			if (reviews.Count == 0)
			{
				return null;
			}

			int[] Summary = new int[5] {0,0,0,0,0};
			for (int i = 1; i <= 5; i++)
			{
				foreach (Review review in reviews)
				{
					if (review.Rating == i)
					{
						Summary[i - 1] += 1;
					}
				}
			}
			return Summary;
		}

	}
}
