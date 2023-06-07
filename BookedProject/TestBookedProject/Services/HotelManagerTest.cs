using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Exceptions;
using Booked.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBookedProject.Mocks;

namespace TestBookedProject.Services
{
    [TestClass]
    public class HotelManagerTest
	{
        //Adding hotel
        [TestMethod]
        public void AddHotelTest()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

			manager.AddHotel(hotel);
			int i = manager.GetAllHotel().Count();

            Assert.AreEqual(1, i);
        }

        [TestMethod]
        public void CheckIfHotelExist_When_Added_Should_ThrowException()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotel2 = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

            manager.AddHotel(hotel1);

			Assert.ThrowsException<HotelExistException>(() => manager.AddHotel(hotel2), "Hotel already exist");
		}

        //Remove hotel
        [TestMethod]
        public void RemoveHotelTest()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1,"Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotel2 = new Hotel(2,"Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.SINGLE, 5, bytes);
            Hotel hotel3 = new Hotel(3,"Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.FAMILY, 5, bytes);

            manager.AddHotel(hotel1);
            manager.AddHotel(hotel2);
            manager.AddHotel(hotel3);
            manager.RemoveHotel(1);
            int count = manager.GetAllHotel().Count();

            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void RemoveHotel_ID_Not_Exist_ShouldThrowException()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

            manager.AddHotel(hotel1);

            Assert.ThrowsException<Exception>(() => manager.RemoveHotel(3), "Cannot remove hotel");
        }

        //Update
        [TestMethod]
        public void UpdateHotelTest()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotelUpdated = new Hotel(1, "Hilton", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

            manager.AddHotel(hotel1);
            manager.UpdateHotel(hotelUpdated);

            Hotel resultHotel = manager.GetHotel(1);
            Assert.IsNotNull(resultHotel);
            Assert.AreEqual("Hilton", resultHotel.Name);
        }

        [TestMethod]
        public void UpdateHotel_ID_Not_Exist_ShouldThrowException()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotelUpdated = new Hotel(3, "Hilton", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

            manager.AddHotel(hotel1);

            Assert.ThrowsException<Exception>(() => manager.UpdateHotel(hotelUpdated), "Cannot update hotel");
        }

        //Get hotel
        [TestMethod]
        public void GetHotelByID_Test()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

            manager.AddHotel(hotel1);
            Hotel hotelFound = manager.GetHotel(1);
            
            Assert.IsNotNull(hotelFound);
        }

        [TestMethod]
        public void GetHotel_Id_Does_Not_Exist_Should_Return_Null()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

            manager.AddHotel(hotel1);
            Hotel hotelFound = manager.GetHotel(3);

            Assert.IsNull(hotelFound);
        }

        [TestMethod]
        public void GetAllHotelTest()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotel2 = new Hotel(2, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.SINGLE, 5, bytes);
            Hotel hotel3 = new Hotel(3, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.FAMILY, 5, bytes);

            manager.AddHotel(hotel1);
            manager.AddHotel(hotel2);
            manager.AddHotel(hotel3);

            int count = manager.GetAllHotel().Count();
            Assert.AreEqual(3, count);
        }

        //Searchbar
        [TestMethod]
        public void GetAllHotel_By_Search_NameOfHotel()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotel2 = new Hotel(2, "Marriot", "Bob street", "Breda", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.SINGLE, 5, bytes);
            Hotel hotel3 = new Hotel(3, "Hilton", "Bob street", "Tilburg", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.FAMILY, 5, bytes);

            manager.AddHotel(hotel1);
            manager.AddHotel(hotel2);
            manager.AddHotel(hotel3);

            int count = manager.GetHotelBySearch("Marriot", null, 5, 0).Count();
            Assert.AreEqual(2, count);
        }

        [TestMethod]
        public void GetAllHotelBySearch_Name_Does_Not_Exist_Return_Zero()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel(1, "Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotel2 = new Hotel(2, "Marriot", "Bob street", "Breda", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.SINGLE, 5, bytes);
            Hotel hotel3 = new Hotel(3, "Hilton", "Bob street", "Tilburg", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.FAMILY, 5, bytes);

            manager.AddHotel(hotel1);
            manager.AddHotel(hotel2);
            manager.AddHotel(hotel3);

            int count = manager.GetHotelBySearch("Holiday inn", null, 5, 0).Count();
            Assert.AreEqual(0, count);
        }


    }
}
