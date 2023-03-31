using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

namespace BookedWebApp.Pages
{
    [Authorize]
    public class UserInfoModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
