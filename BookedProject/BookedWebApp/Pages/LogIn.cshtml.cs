using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Booked.Domain.Domain;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Booked.Logic.Services;

namespace BookedWebApp.Pages
{
    public class LogInModel : PageModel
    {
        private readonly UserManager userManager;

        public LogInModel()
        {
            userManager = new UserManager();
        }


        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {
        }

        //Need to finish the login
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (userManager.CheckPassword(User.Password, User.Email))
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, User.Email)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));

                    ViewData["Message"] = "Log in succcesfull";
                    return Redirect("~/Index");
                }
                else
                {
                    ViewData["Message"] = "Email or password is incorrect";
                    return Page();
                }

            }
            return Page();
        }
    }
}
