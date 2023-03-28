using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages
{
    public class HotelDetailsModel : PageModel
    {
		public Hotel Hotel { get; private set; }
		
        public void OnGet(int id)
        {
            HotelManager hotelManager = new HotelManager();
            Hotel = hotelManager.GetHotel(id);
        }
    }
}
