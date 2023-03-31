using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Booked.Domain.Domain;

namespace BookedWebApp.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {
        }

        //Need to finish the login
        public void OnPost()
        {
        }
    }
}
