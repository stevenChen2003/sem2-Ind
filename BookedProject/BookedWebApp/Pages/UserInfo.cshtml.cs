using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

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
