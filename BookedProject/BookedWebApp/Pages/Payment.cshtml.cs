using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
	[Authorize]
	public class PaymentModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
