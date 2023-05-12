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
		public void AddReview(Review review)
		{

		}

		//Check if user has review on the hotel
		public bool CheckIfReviewExist(Review review)
		{
			return false;
		}

		//Get

		//Update

		//Delete
		
	}
}
