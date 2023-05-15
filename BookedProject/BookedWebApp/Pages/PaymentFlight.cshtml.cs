using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class PaymentFlightModel : PageModel
    {
        private readonly BookingManager bookingManager;
        private readonly FlightManager flightManager;
        private readonly UserManager userManager;

        public PaymentFlightModel(BookingManager bookingManager, FlightManager flightManager, UserManager userManager)
        {
            this.bookingManager = bookingManager;
            this.flightManager = flightManager;
            this.userManager = userManager;
        }

        public FlightBooking flightBooking { get; set; }
        public FlightBooking flightBooking2 { get; set; }
        public User user { get; set; }


		[BindProperty]
		public int flightId { get; set; }
		public Flight flight { get; set; }
		[BindProperty]
		public DateTime start { get; set; }
		[BindProperty]
		public DateTime end { get; set; }


		public void OnGet(int flightId, DateTime start, DateTime end, bool extra)
        {
			string userEmail = User.Identity.Name;
			user = userManager.GetUser(userEmail);
            flight = flightManager.GetFlight(flightId);
			flightBooking = new FlightBooking(user, start, end, DateTime.Today, flight, extra);
		}


    }
}
