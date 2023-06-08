using Booked.Domain.Domain;
using Booked.Logic.Exceptions;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class AllUserModel : PageModel
    {
        private readonly UserManager userManager;
        private readonly BookingManager bookingManager;

        public AllUserModel(UserManager mng, BookingManager bookingManager)
        {
            userManager = mng;
            this.bookingManager = bookingManager;
        }

        public IEnumerable<User> UserList { get; set; }

        public void OnGet()
        {
            try
            {
				UserList = userManager.GetAllUsers();
			}
            catch (GetException ex)
            {
                TempData["Message"] = ex.Message;
            }
        }
    }
}
