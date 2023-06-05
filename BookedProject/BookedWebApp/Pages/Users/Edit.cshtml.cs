using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using BookedWebApp.DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages.Users
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly UserManager userManager;

        public EditModel(UserManager mng)
        {
            userManager = mng;
        }

        public User user { get; set; }

        //DTO's
        [BindProperty]
        public UpdateUser UpdateUser { get; set; }

        public void OnGet()
        {
            string userEmail = User.Identity.Name;
            user = userManager.GetUser(userEmail);
            UpdateUser = new UpdateUser(user);
        }

        public IActionResult OnPostUpdate()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            try
            {
                user = UpdateUser.GetUser();
                userManager.UpdateUser(user);
				return Redirect("/Users/Details");
			}
            catch (Exception e)
            {
                ViewData["Message"] = e.Message;
				return Page();
            }
        }

        public IActionResult OnPostDelete()
        {
            try
            {
                user = UpdateUser.GetUser();
                userManager.DeleteUser(user.UserId);
				HttpContext.SignOutAsync();
				return Redirect("~/Login");
			}
            catch (Exception e)
			{
				ViewData["Message"] = e.Message;
				return Page();
			}
        }

    }
}
