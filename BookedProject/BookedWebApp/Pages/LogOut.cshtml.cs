using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    [Authorize]
    public class LogOutModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            HttpContext.SignOutAsync();
            return RedirectToPage("Login");
        }

    }
}
