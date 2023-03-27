using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class HotelsModel : PageModel
    {
        public IEnumerable<Hotel> DetailsHotel { get; set; }

        public void OnGet()
        {
            HotelManager mng = new HotelManager();
            DetailsHotel = mng.GetAllHotel();
        }
    }
}
