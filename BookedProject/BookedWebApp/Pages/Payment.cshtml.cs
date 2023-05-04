using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
	[Authorize]
	public class PaymentModel : PageModel
    {
        private readonly HotelBookingManager hotelBookingManager;
        private readonly UserManager userManager;

        public PaymentModel()
        {
            hotelBookingManager = new HotelBookingManager(new HotelBookingRepository());
			userManager = new UserManager(new UserRepository());
		}

        public User user { get; set; }

        public HotelBooking hotelBooking { get; set; }

        public void OnGet(Hotel hotel, DateTime start, DateTime end)
        {
			string userEmail = User.Identity.Name;
			user = userManager.GetUser(userEmail);
			hotelBooking = new HotelBooking(user, start, end, DateTime.Today, hotel);
        }
    }
}
