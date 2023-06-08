using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Exceptions;
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
		private readonly BookingManager _bookingManager;
        private readonly HotelManager hotelManager;
        private readonly UserManager userManager;

        public PaymentModel(HotelManager hotelManager, UserManager userManager, BookingManager bookingManager)
        {
			this.hotelManager = hotelManager;
			this.userManager = userManager;
			_bookingManager = bookingManager;
		}

		public HotelBooking hotelBooking { get; set; }
		public User user { get; set; }
		
		[BindProperty]
		public int hotelId { get; set; }
		public Hotel hotel { get; set; }
		[BindProperty]
		public DateTime start { get; set; }
		[BindProperty]
		public DateTime end { get; set; }

        public void OnGet(int hotelId, DateTime start, DateTime end)
        {
			try
			{
                string userEmail = User.Identity.Name;
                user = userManager.GetUser(userEmail);
                hotel = hotelManager.GetHotel(hotelId);
                hotelBooking = new HotelBooking(user, start, end, DateTime.Today, hotel);
            }
			catch (GetException ex)
			{
                TempData["Message"] = ex.Message;
            }
		}

        public IActionResult OnPost()
        {
			if (ModelState.IsValid)
            {
				try
				{
                    string userEmail = User.Identity.Name;
                    user = userManager.GetUser(userEmail);
                    hotel = hotelManager.GetHotel(hotelId);
                    hotelBooking = new HotelBooking(user, start, end, DateTime.Today, hotel);
                    _bookingManager.AddBooking(hotelBooking);
					TempData["BookingCompletedMessage"] = "Your booking has been successfully completed.";
					return RedirectToPage("/Index");
				}
				catch (GetException)
				{
					TempData["Message"] = "Error making booking,";
				}
			}
            return Page();
        }
    }
}
