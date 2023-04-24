using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Booked.Domain.Domain;
using Booked.Logic.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Booked.Infrastructure.Repositories;

namespace BookedWebApp.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager userManager;

        public RegisterModel()
        {
            userManager = new UserManager(new UserRepository());
        }

        [BindProperty]
        public User User { get; set; }


        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (userManager.AddUser(User))
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, User.Email)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
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
