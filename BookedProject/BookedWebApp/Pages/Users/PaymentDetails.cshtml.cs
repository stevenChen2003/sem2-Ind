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
        private readonly HotelManager hotelManager;
        private readonly FlightManager flightManager;

        public PaymentDetailsModel(BookingManager bookingManager, HotelManager hotelManager, FlightManager flightManager)
        {
            this.bookingManager = bookingManager;
            this.hotelManager = hotelManager;
            this.flightManager = flightManager;
        }

        public FlightBooking FlightBooking { get; set; }
        public HotelBooking HotelBooking { get; set; }

        public void OnGet(int id)
        {
            if (bookingManager.GetBookingByid(id) is FlightBooking)
			{
                FlightBooking  = (FlightBooking)bookingManager.GetBookingByid(id);
                FlightBooking.Flight = flightManager.GetFlight(FlightBooking.Flight.FlightId);
			}
            else if (bookingManager.GetBookingByid(id) is HotelBooking)
            {
				HotelBooking = (HotelBooking)bookingManager.GetBookingByid(id);
                HotelBooking.Hotel = hotelManager.GetHotel(HotelBooking.Hotel.HotelId);
			}


		}
    }
}
