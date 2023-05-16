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

        //Pagenation
        public int CurrentPage { get; set; } = 1;
        public int ItemsPerPage { get; set; } = 6;
        public int TotalItems { get; set; }

		public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalItems, ItemsPerPage));


		public void OnGet(string depart, string arrive, int currentPage)
        {
            Countries = flightManager.GetCountries();
            CurrentPage = currentPage > 0? currentPage : 1;

            if (!string.IsNullOrEmpty(depart) && !string.IsNullOrEmpty(arrive))
            {
                this.depart = depart;
                this.arrive = arrive;
            }
            FlightsList = flightManager.GetFlightsBySearch(depart, arrive, ItemsPerPage, (CurrentPage - 1) * ItemsPerPage);
			TotalItems = flightManager.GetTotalFlightsCount(depart, arrive);
		}
    }
}
