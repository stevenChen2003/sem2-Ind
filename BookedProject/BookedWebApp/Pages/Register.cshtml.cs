using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Booked.Domain.Domain;
using Booked.Logic.Services;

namespace BookedWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager userManager;

        public RegisterModel()
        {
            userManager = new UserManager();
        }

        [BindProperty]
        public User User { get; set; }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (userManager.AddUser(User))
                {
                    ViewData["Message"] = "Account Created";

                    return Redirect("~/Index");
                }
                else
                {
                    ViewData["Message"] = "Email already exists.";
                    return Page();
                }

            }
            return Page();
        }
    }
}
