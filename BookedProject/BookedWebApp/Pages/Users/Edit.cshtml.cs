using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using BookedWebApp.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages.Users
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly UserManager userManager;

        public EditModel()
        {
            userManager = new UserManager(new UserRepository());
        }

        /// <summary>
        /// Need to change and use DTO
        /// </summary>
        [BindProperty]
        public User user { get; set; }

        //[BindProperty]
        public UpdateUser UpdateUser { get; set; }

        public void OnGet()
        {
            string userEmail = User.Identity.Name;
            user = userManager.GetUser(userEmail);
        }

        public IActionResult OnPost()
        {
            if (userManager.UpdateUser(user))
            {
                return Redirect("/Users/Details");
            }
            return Page();
        }

        public IActionResult OnPostDelete()
        {
            if (userManager.DeleteUser(user.Email))
            {
                return Redirect("/Index");
            }
            return Page();
        }

    }
}
