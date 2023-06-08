using Booked.Domain.Domain;
using Booked.Logic.Exceptions;
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

        public Flight Flight { get; private set; }

		[BindProperty]
		public DateTime DateStart { get; set; }
		[BindProperty]
		public DateTime DateEnd { get; set; }
		[BindProperty]
		public bool extra { get; set; }


		public void OnGet(int id)
        {
			try
			{
                Flight = flightManager.GetFlight(id);
            }
			catch(GetException ex)
			{
                TempData["Error"] = ex.Message;
            }
        }

		public IActionResult OnPost(int id)
		{
			Flight = flightManager.GetFlight(id);

			if (ModelState.IsValid && DateStart >= DateTime.Today && DateEnd > DateStart)
			{
				return RedirectToPage("/PaymentFlight", new { start = DateStart.ToString("yyyy-MM-dd"), end = DateEnd.ToString("yyyy-MM-dd"), flightId = id, Extra = extra });
			}
			else
			{
				TempData["Message"] = "Date's are incorrect";
				return Page();
			}
		}

	}
}
