using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Exceptions;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages.Users
{
    [Authorize]
    public class DetailsModel : PageModel
    {
        private readonly UserManager userManager;
        private readonly BookingManager bookingManager;

        public DetailsModel(UserManager mng, BookingManager bookingManager)
        {
            userManager = mng;
            this.bookingManager = bookingManager;
        }

        [BindProperty]
        public User user { get; set; }

        public void OnGet()
        {
            try
            {
                string userEmail = User.Identity.Name;
                user = userManager.GetUser(userEmail);
                user.Bookings = bookingManager.GetAllBookingByUserId(user.UserId);
            }
            catch (GetException ex)
            {
                TempData["Error"] = ex.Message;
            }
        }
    }
}
