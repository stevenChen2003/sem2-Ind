using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Booked.Domain.Domain;
using Booked.Logic.Services;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Booked.Infrastructure.Repositories;
using BookedWebApp.DTO;
using Booked.Logic.Exceptions;

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
        public CreateUserDTO Creadentials { get; set; }

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
                User user = Creadentials.GetUser();
                try
                {
                    userManager.AddUser(user);
					List<Claim> claims = new List<Claim>
					{
						new Claim(ClaimTypes.Name, user.Email)
					};
					var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
					HttpContext.SignInAsync(new ClaimsPrincipal(claimsIdentity));
					return Redirect("~/Index");

				}
                catch (EmailExistException)
                {
					ViewData["Message"] = "Email already exists.";
					return Page();
				}
                catch (Exception ex)
                {
                    ViewData["Message"] = ex.Message;
                    return Page();
                }

            }
            return Page();
        }
    }
}
