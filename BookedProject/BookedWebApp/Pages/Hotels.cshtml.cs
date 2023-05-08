using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class HotelsModel : PageModel
    {
        public IEnumerable<Hotel> ListHotel { get; set; }
        public string query { get; set; }

        public void OnGet(string query)
        {
            HotelManager mng = new HotelManager(new HotelRepository());
            ListHotel = mng.GetHotelsByCountry(query);
        }
    }
}
