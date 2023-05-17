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

        //SearchBar
        public string query { get; set; }
        public string SortOrder { get; set; }

        //Pagination
		public int CurrentPage { get; set; } = 1;
		public int ItemsPerPage { get; set; } = 2;
		public int TotalItems { get; set; }

		public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalItems, ItemsPerPage));

        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;
        public bool ShowFirst => CurrentPage != 1;
        public bool ShowLast => CurrentPage != TotalPages;

        /*
        [BindProperty]
        public DateTime CheckInDate { get; set; }
        [BindProperty]
        public DateTime CheckOutDate { get; set; }*/

        public void OnGet(string query, string SortOrder, int currentPage)
        {
			CurrentPage = currentPage > 0 ? currentPage : 1;
			if (!string.IsNullOrEmpty(query) || !string.IsNullOrEmpty(SortOrder))
			{
				this.query = query;
				this.SortOrder = SortOrder;
			}

			ListHotel = hotelManager.GetHotelsByCountry(query, SortOrder, ItemsPerPage, (CurrentPage - 1) * ItemsPerPage);
            TotalItems = hotelManager.GetTotalHotelCount(query);
		}
    }
}
