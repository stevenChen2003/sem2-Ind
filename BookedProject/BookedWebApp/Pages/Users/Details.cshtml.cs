using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
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

        public DetailsModel()
        {
            userManager = new UserManager(new UserRepository());
        }

        [BindProperty]
        public User user { get; set; }

        public void OnGet()
        {
            string userEmail = User.Identity.Name;
            user = userManager.GetUser(userEmail);
        }
    }
}
