using Booked.Domain.Domain;
using Booked.Infrastructure.Repositories;
using Booked.Logic.Exceptions;
using Booked.Logic.Exceptions.HotelException;
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
		public int ItemsPerPage { get; set; } = 3;
		public int TotalItems { get; set; }

		public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalItems, ItemsPerPage));

        public bool ShowPrevious => CurrentPage > 1;
        public bool ShowNext => CurrentPage < TotalPages;


        public void OnGet(string query, string SortOrder, int currentPage)
        {
			CurrentPage = currentPage > 0 ? currentPage : 1;
			if (!string.IsNullOrEmpty(query) || !string.IsNullOrEmpty(SortOrder))
			{
				this.query = query;
				this.SortOrder = SortOrder;
			}
            try
            {
                ListHotel = hotelManager.GetHotelBySearch(query, SortOrder, ItemsPerPage, (CurrentPage - 1) * ItemsPerPage);
                TotalItems = hotelManager.GetTotalHotelCount(query);
            }
            catch (GetHotelException ex)
            {
                TempData["Error"] = ex.Message;
            }
		}
    }
}
