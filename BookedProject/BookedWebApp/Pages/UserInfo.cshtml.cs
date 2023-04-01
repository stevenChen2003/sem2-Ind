using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Booked.Domain.Domain;
using Booked.Logic.Services;

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
