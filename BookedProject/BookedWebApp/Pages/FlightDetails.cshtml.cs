using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class FlightDetailsModel : PageModel
    {
        public readonly FlightManager flightManager;

        public FlightDetailsModel(FlightManager _flightManager)
        {
            flightManager = _flightManager;
        }

        public Flight Flight { get; set; }

		[BindProperty]
		public DateTime DateStart { get; set; }
		[BindProperty]
		public DateTime DateEnd { get; set; }


		public void OnGet(int id)
        {
            Flight = flightManager.GetFlight(id);
        }

		/*
		public IActionResult OnPost(int id)
		{
			Flight = flightManager.GetFlight(id);

			if (ModelState.IsValid)
			{
				return RedirectToPage("/Payment", new { start = DateStart.ToString("yyyy-MM-dd"), end = DateEnd.ToString("yyyy-MM-dd"), hotelId = id });
			}
			else
			{
				//Display messege that the dates are not filled int
				return Page();
			}
		}*/
	}
}
