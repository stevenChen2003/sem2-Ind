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
        private readonly HotelManager hotelManager;
        private readonly UserManager userManager;

        public PaymentModel()
        {
            hotelBookingManager = new HotelBookingManager(new HotelBookingRepository());
            hotelManager = new HotelManager(new HotelRepository());
			userManager = new UserManager(new UserRepository());
		}

        public User user { get; set; }
        public Hotel hotel { get; set; }
        public HotelBooking hotelBooking { get; set; }

        public void OnGet(int hotelId, DateTime start, DateTime end)
        {
			string userEmail = User.Identity.Name;
			user = userManager.GetUser(userEmail);
            hotel = hotelManager.GetHotel(hotelId);
			hotelBooking = new HotelBooking(user, start, end, DateTime.Today, hotel);
        }

        public IActionResult OnPost()
        {
            return Page();
        }
    }
}
