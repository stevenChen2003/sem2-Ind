using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class LogOutModel : PageModel
    {
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            HttpContext.SignOutAsync();
            return RedirectToPage("Login");
        }
    }
}
