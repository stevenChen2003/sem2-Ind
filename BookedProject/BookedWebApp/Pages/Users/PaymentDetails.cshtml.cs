using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Services;
using BookedWebApp.DTO;
using Microsoft.AspNetCore.Authentication;
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
        private readonly UserManager userManager;

        public PaymentDetailsModel(BookingManager bookingManager, HotelManager hotelManager, FlightManager flightManager, UserManager userManager)
        {
            this.bookingManager = bookingManager;
            this.hotelManager = hotelManager;
            this.flightManager = flightManager;
            this.userManager = userManager;
        }

        public FlightBooking FlightBooking { get; set; }
        public HotelBooking HotelBooking { get; set; }

        public IActionResult OnGet(int id)
        {
            User user = userManager.GetUser(User.Identity.Name);
            if (bookingManager.GetBookingByid(id) is FlightBooking)
			{
                FlightBooking  = (FlightBooking)bookingManager.GetBookingByid(id);
                FlightBooking.Flight = flightManager.GetFlight(FlightBooking.Flight.FlightId);
                if (user.UserType == UserType.Admin || FlightBooking.User.UserId == user.UserId)
                {
                    return Page();
                }
                else
                {
                    return Redirect("/AccessDenied");
                }
            }
            else if (bookingManager.GetBookingByid(id) is HotelBooking)
            {
				HotelBooking = (HotelBooking)bookingManager.GetBookingByid(id);
                HotelBooking.Hotel = hotelManager.GetHotel(HotelBooking.Hotel.HotelId);
                if (user.UserType == UserType.Admin || FlightBooking.User.UserId == user.UserId)
                {
                    return Page();
                }
                else
                {
                    return Redirect("/AccessDenied");
                }
            }
            return Page();
        }

		public IActionResult OnPostUpdate(int id)
		{
			try
			{
                Booking booking = bookingManager.GetBookingByid(id);
                booking.Status = "Cancelled";
                bookingManager.UpdateBooking(booking);
				if (User.IsInRole("Admin"))
				{
					return Redirect("/Admin/Bookings");
				}
				return Redirect("/Users/Details");
			}
			catch (Exception e)
			{
				TempData["Message"] = e.Message;
				return RedirectToPage("/Users/PaymentDetails", new { id = id });
			}
		}

		public IActionResult OnPostDelete(int id)
		{
			try
			{
                bookingManager.DeleteBooking(id);
                if (User.IsInRole("Admin"))
                {
					return Redirect("/Admin/Bookings");
				}
                return Redirect("/Users/Details");
			}
			catch (Exception e)
			{
				TempData["Message"] = e.Message;
				return RedirectToPage("/Users/PaymentDetails", new { id = id });
			}
		}

	}
}
