using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class HotelDetailsModel : PageModel
    {
		public Hotel Hotel { get; private set; }

        [BindProperty]
        public DateTime DateStart { get; set; }
		[BindProperty]
		public DateTime DateEnd { get; set; }

		public void OnGet(int id)
        {
            HotelManager hotelManager = new HotelManager(new HotelRepository());
            Hotel = hotelManager.GetHotel(id);
		}

		public IActionResult OnPost(int id)
		{
			if (ModelState.IsValid)
			{
				return RedirectToPage("~/Payment");
			}
			else
			{
				return RedirectToPage("/HotelDetails", new { id });
			}
		}
	}
}
