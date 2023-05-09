using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class HotelsModel : PageModel
    {
        private readonly HotelManager hotelManager;

        public HotelsModel(HotelManager hotelManager)
        {
            this.hotelManager = hotelManager;
        }

        public IEnumerable<Hotel> ListHotel { get; set; }
        public string query { get; set; }
        public string SortOrder { get; set; }

        public void OnGet(string query)
        {
            ListHotel = hotelManager.GetHotelsByCountry(query);
        }
    }
}
