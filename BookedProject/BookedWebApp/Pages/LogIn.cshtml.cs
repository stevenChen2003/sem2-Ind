using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Booked.Logic.Services;
using System.ComponentModel.DataAnnotations;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Exceptions;

namespace BookedWebApp.Pages
{
	public class LogInModel : PageModel
    {
        private readonly UserManager userManager;

        public LogInModel(UserManager mng)
        {
            userManager = mng;
        }

        [BindProperty]
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BindProperty]
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        public User FoundUser { get; set; }

		public async Task<IActionResult> OnGetAsync(string returnUrl = null)
		{
			if (User.Identity.IsAuthenticated)
			{
				return RedirectToPage("/Index");
			}
            return Page();
		}

		public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                try
                {
					if (userManager.CheckPassword(Password, Email))
					{
						FoundUser = userManager.GetUser(Email);

						List<Claim> claims = new List<Claim>
						{
							new Claim(ClaimTypes.Name, FoundUser.Email)
						};

						if (FoundUser.UserType == UserType.Admin)
						{
							claims.Add(new Claim(ClaimTypes.Role, "Admin"));
						}
						var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
						HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
						return RedirectToPage("/Index");
					}
					else
					{
						TempData["Message"] = "Incorrect password or email.";
						return Page();
					}
				}
                catch (GetException ex)
                {
					TempData["Message"] = ex.Message;
				}
            }
            return Page();
        }
    }
}
