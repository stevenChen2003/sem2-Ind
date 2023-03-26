using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BookedWebApp.Modals;

namespace BookedWebApp.Pages
{
    public class LogInModel : PageModel
    {
        [BindProperty]
        public User User { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {

            }
            else
            {

            }
        }
    }
}
