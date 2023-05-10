using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class FlightModel : PageModel
    {
        private readonly FlightManager flightManager;

        public FlightModel(FlightManager flightManager)
        {
            this.flightManager = flightManager;
        }

        public IEnumerable<string> Countries { get; set; }
        public IEnumerable<Flight> FlightsList { get; set; }

        public void OnGet()
        {
            Countries = flightManager.GetCountries();
            FlightsList = flightManager.GetAllFlight();
        }
    }
}
