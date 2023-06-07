using Booked.Domain.Domain.Enum;
using Booked.Domain.Domain;
using Booked.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBookedProject.Mocks;
using Booked.Logic.Interfaces;

namespace TestBookedProject.Services
{
    [TestClass]
    public class BookingManagerTest
	{
        //Adding booking
        [TestMethod]
        public void AddHotelBooking_Test()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(3,"Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            byte[] bytes = { 7 };
            Hotel hotel = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            HotelBooking hotelBooking = new HotelBooking(1,user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, hotel, "Paid");

            manager.AddBooking(hotelBooking);

            Assert.IsNotNull(manager.GetBookingByid(1));
        }

        [TestMethod]
        public void AddFlightBooking_Test()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(3, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            FlightBooking flightBooking = new FlightBooking(3, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");

            manager.AddBooking(flightBooking);

            Assert.IsNotNull(manager.GetBookingByid(3));
        }

        //Get hotel
        [TestMethod]
        public void GetBookingByID_Test()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(3, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            FlightBooking flightBooking = new FlightBooking(1, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");

            manager.AddBooking(flightBooking);

            Assert.IsNotNull(manager.GetBookingByid(1));
        }

        [TestMethod]
        public void GetBookingByID_Id_Does_Not_Exist_Should_Return_Null()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(3, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            FlightBooking flightBooking = new FlightBooking(3, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");

            manager.AddBooking(flightBooking);

            Assert.IsNull(manager.GetBookingByid(4));
        }

        //Get hotel by UserId 
        [TestMethod]
        public void GetBookingListByUserID_Test()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            User user2 = new User(3, "Steven", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            byte[] bytes = { 7 };
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Hotel hotel = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            FlightBooking flightBooking = new FlightBooking(1, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");
            HotelBooking hotelBooking = new HotelBooking(1, user2, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, hotel, "Paid");

            manager.AddBooking(flightBooking);
            manager.AddBooking(hotelBooking);
            int count = manager.GetAllBookingByUserId(3).Count();

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        public void GetBookingListByUserID_With_No_Booking_Return_Zero()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(3, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            byte[] bytes = { 7 };
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Hotel hotel = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            FlightBooking flightBooking = new FlightBooking(3, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");
            HotelBooking hotelBooking = new HotelBooking(1, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, hotel, "Paid");

            manager.AddBooking(flightBooking);
            manager.AddBooking(hotelBooking);
            int count = manager.GetAllBookingByUserId(4).Count();

            Assert.AreEqual(0, count);
        }

        //Get All Booking
        [TestMethod]
        public void GetBookingListBy_Test()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(3, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            User user2 = new User(3, "Steven", "Wu", "s.wu@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            byte[] bytes = { 7 };
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Hotel hotel = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            FlightBooking flightBooking = new FlightBooking(1, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");
            HotelBooking hotelBooking = new HotelBooking(3, user2, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, hotel, "Paid");

            manager.AddBooking(flightBooking);
            manager.AddBooking(hotelBooking);
            int count = manager.GetAllBooking().Count();

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void GetAllBooking_With_No_Booking_Return_Zero()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());

            int count = manager.GetAllBooking().Count();

            Assert.AreEqual(0, count);
        }

        //Delete
        [TestMethod]
        public void DeleteBooking_Test()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(1, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            
            FlightBooking flightBooking = new FlightBooking(1, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");

            manager.AddBooking(flightBooking);
            manager.DeleteBooking(1);
            int count = manager.GetAllBooking().Count();

            Assert.AreEqual(0, count);
        }


        //Update
        [TestMethod]
        public void CancellBooking_Test()
        {
            BookingManager manager = new BookingManager(new FakeBookingRepo());
            User user = new User(3, "Steven", "Chen", "s.chen@company.nl", new DateTime(1980, 1, 1), "789987", "password", UserType.Client);
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            
            FlightBooking flightBooking = new FlightBooking(1, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Paid");
            FlightBooking flightBookingUpdate = new FlightBooking(1, user, DateTime.Today.AddDays(1), DateTime.Today.AddDays(2), DateTime.Today, flight, true, "Cancelled");

            manager.AddBooking(flightBooking);
            manager.UpdateBooking(flightBookingUpdate);

            Booking resultBooking = manager.GetBookingByid(1);
            Assert.IsNotNull(resultBooking);
            Assert.AreEqual("Cancelled", resultBooking.Status);
        }

    }
}
