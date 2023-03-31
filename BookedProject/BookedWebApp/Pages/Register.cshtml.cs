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

        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                userManager.AddUser(User);
                return Redirect("~/Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
