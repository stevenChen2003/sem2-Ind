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

        public string depart { get; set; }
        public string arrive { get; set; }

        public void OnGet(string depart, string arrive)
        {
            Countries = flightManager.GetCountries();
            FlightsList = flightManager.GetFlightsBySearch(depart, arrive);
        }
    }
}
