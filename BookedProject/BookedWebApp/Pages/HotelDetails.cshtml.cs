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

		public HotelDetailsModel()
		{
			hotelManager = new HotelManager(new HotelRepository());
		}

		public Hotel Hotel { get; private set; }

        [BindProperty]
        public DateTime DateStart { get; set; }
		[BindProperty]
		public DateTime DateEnd { get; set; }

		public void OnGet(int id)
        {
            Hotel = hotelManager.GetHotel(id);
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
				//Display messege that the dates are not filled int
				return Page();
			}
		}
	}
}
