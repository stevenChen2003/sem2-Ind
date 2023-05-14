using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
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
        [TestMethod]
        public void AddHotelTest()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);

            bool result = manager.AddHotel(hotel);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfHotelExist_When_Added()
        {
            HotelManager manager = new HotelManager(new FakeHotelRepo());
            byte[] bytes = { 7 };
            Hotel hotel1 = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotel2 = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.NORMAL, 5, bytes);
            Hotel hotel3 = new Hotel("Marriot", "Bob street", "Eindhoven", "Netherlands", 5, Convert.ToDecimal(555.55), Rooms.FAMILY, 5, bytes);

            manager.AddHotel(hotel1);
            bool result = manager.AddHotel(hotel2); 
            bool result2 = manager.AddHotel(hotel3);
            
            Assert.IsFalse(result);
            Assert.IsTrue(result2);
        }

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




    }
}
