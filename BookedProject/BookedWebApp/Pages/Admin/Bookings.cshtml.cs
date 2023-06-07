using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class BookingsModel : PageModel
    {
        private readonly UserManager userManager;
        private readonly BookingManager bookingManager;

        public BookingsModel(UserManager mng, BookingManager bookingManager)
        {
            userManager = mng;
            this.bookingManager = bookingManager;
        }

        public IEnumerable<Booking> BookingList { get; set; }

        public void OnGet()
        {
            BookingList = bookingManager.GetAllBooking();
        }
    }
}
