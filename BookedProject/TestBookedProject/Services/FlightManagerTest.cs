using Booked.Domain.Domain.Enum;
using Booked.Domain.Domain;
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
	public class FlightManagerTest
	{
		[TestMethod]
        public void AddFlightTest()
        {
            FlightManager manager = new FlightManager(new FakeFlightRepo());
            Flight flight = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);

            bool result = manager.AddFlight(flight);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIfHotelExist_When_Added()
        {
            FlightManager manager = new FlightManager(new FakeFlightRepo());
            Flight flight1 = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Flight flight2= new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Flight flight3 = new Flight("KLM", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);

            manager.AddFlight(flight1);
            bool result = manager.AddFlight(flight2);
            bool result2 = manager.AddFlight(flight3);

            Assert.IsFalse(result);
            Assert.IsTrue(result2);
        }


        [TestMethod]
        public void RemoveFlightTest()
        {

        }


    }
}
