using Booked.Domain.Domain;
using Booked.Logic.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookedWebApp.Pages.Users
{
    [Authorize]
    public class PaymentDetailsModel : PageModel
    {
        private readonly BookingManager bookingManager;

        public PaymentDetailsModel(BookingManager bookingManager)
        {
            this.bookingManager = bookingManager;
        }

        public FlightBooking FlightBooking { get; set; }
        public HotelBooking HotelBooking { get; set; }

        public void OnGet(int id)
        {
            if (bookingManager.GetBookingByid(id) is HotelBooking)
            {
                HotelBooking = (HotelBooking)bookingManager.GetBookingByid(id);

			}
            else if (bookingManager.GetBookingByid(id) is FlightBooking)
			{
                FlightBooking  = (FlightBooking)bookingManager.GetBookingByid(id);
			}

        }
    }
}
