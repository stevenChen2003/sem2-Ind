using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace BookedWebApp.Pages
{
	public class HotelDetailsModel : PageModel
	{
		private readonly HotelManager hotelManager;
		private readonly ReviewManager reviewManager;
		private readonly UserManager userManager;

		public HotelDetailsModel(HotelManager mng, ReviewManager reviewManager, UserManager userManager)
		{
			hotelManager = mng;
			this.reviewManager = reviewManager;
			this.userManager = userManager;
		}

		public Hotel Hotel { get; private set; }

		[BindProperty]
		public DateTime DateStart { get; set; }
		[BindProperty]
		public DateTime DateEnd { get; set; }

        [BindProperty]
        public int ReviewId { get; set; }

		public int[] SummaryReview { get; set; }

        public void OnGet(int id)
        {
			Hotel = hotelManager.GetHotel(id);
            Hotel.Reviews = reviewManager.GetReviewsBaseOnHotelId(id);

			Hotel.StarRating = reviewManager.GetAvgRating(id);
			SummaryReview = reviewManager.GetSummaryRating(id);
        }

		public IActionResult OnPost(int id)
		{
			Hotel = hotelManager.GetHotel(id);

			if (ModelState.IsValid && DateStart >= DateTime.Today && DateEnd > DateStart)
			{
				return RedirectToPage("/Payment", new { start = DateStart.ToString("yyyy-MM-dd"), end = DateEnd.ToString("yyyy-MM-dd"), hotelId = id });
			}
			else
			{
				//Need to display messege that the dates are not filled in
				return RedirectToPage("/HotelDetails", new {id = id});
			}
		}

		public IActionResult OnPostAddReview(int hotelid, string description, int rating)
		{
			string email = User.Identity.Name;
			User user = userManager.GetUser(email);
			Review review = new Review(user, hotelid, description, rating);
			if (ModelState.IsValid)
			{
				reviewManager.AddReview(review);
                return RedirectToPage("/HotelDetails", new { id = hotelid });
            }
            return RedirectToPage("/HotelDetails", new { id = hotelid });
        }

        public IActionResult OnPostEditReview(string EditDescription, int Editrating)
        {
            Review review = reviewManager.GetReviewById(ReviewId);
			if (ModelState.IsValid)
			{
                review.Description = EditDescription;
				review.Rating = Editrating;
                reviewManager.UpdateReview(review);
                return RedirectToPage("/HotelDetails", new { id = review.HotelId });
            }

            return RedirectToPage("/HotelDetails", new { id = review.HotelId });
        }

        public IActionResult OnPostDeleteReview()
        {
            Review review = reviewManager.GetReviewById(ReviewId);
            if (ModelState.IsValid)
            {
                reviewManager.DeleteReview(review.Id);
                return RedirectToPage("/HotelDetails", new { id = review.HotelId });
            }

            return RedirectToPage("/HotelDetails", new { id = review.HotelId });
        }

    }
}
