using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Identity;

namespace BookedWebApp.Pages
{
    [Authorize]
    public class UserInfoModel : PageModel
    {
		private readonly UserManager userManager;

		public UserInfoModel()
        {
			userManager = new UserManager();
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
