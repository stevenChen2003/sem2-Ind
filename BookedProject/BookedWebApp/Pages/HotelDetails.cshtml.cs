using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class HotelDetailsModel : PageModel
    {
		private readonly HotelManager hotelManager;
		private readonly ReviewManager reviewManager;

		public HotelDetailsModel(HotelManager mng, ReviewManager reviewManager)
		{
			hotelManager = mng;
			this.reviewManager = reviewManager;
		}

		public Hotel Hotel { get; private set; }

        [BindProperty]
        public DateTime DateStart { get; set; }
		[BindProperty]
		public DateTime DateEnd { get; set; }


		public void OnGet(int id)
        {
            Hotel = hotelManager.GetHotel(id);
			Hotel.Reviews = reviewManager.GetReviewsBaseOnHotelId(id);
        }

		public IActionResult OnPost(int id)
		{
			Hotel = hotelManager.GetHotel(id);

			if (ModelState.IsValid)
			{
				return RedirectToPage("/Payment", new { start = DateStart.ToString("yyyy-MM-dd"), end = DateEnd.ToString("yyyy-MM-dd"), hotelId = id });
			}
			else
			{
				//Need to display messege that the dates are not filled in
				return Page();
			}
		}

		public IActionResult OnPostReview(int id)
		{
            return Page();
        }

    }
}
