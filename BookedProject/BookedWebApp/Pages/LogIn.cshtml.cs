using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Booked.Domain.Domain;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Booked.Logic.Services;
using System.ComponentModel.DataAnnotations;

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
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindProperty]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public void OnGet()
        {
        }

        //Need to finish the login
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (userManager.CheckPassword(Password, Email))
                {
                    List<Claim> claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, Email)
                    };
                    var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
                    return Redirect("/Index");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid email or password");
                    return Page();
                }
            }
            return Page();
        }
    }
}
