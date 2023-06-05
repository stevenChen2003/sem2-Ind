using Booked.Domain.Domain.Enum;
using Booked.Domain.Domain;
using Booked.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBookedProject.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Booked.Logic.Exceptions;

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

            manager.AddFlight(flight);
            int i = manager.GetAllFlight().Count();

            Assert.AreEqual(1, i);
        }

        [TestMethod]
        public void CheckIfFlightExist_When_Added_ShouldThrow_FlightExistExeption()
        {
            FlightManager manager = new FlightManager(new FakeFlightRepo());
            Flight flight1 = new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Flight flight2= new Flight("Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);

            manager.AddFlight(flight1);

			Assert.ThrowsException<FlightExistException>(() => manager.AddFlight(flight2), "Flight already exist");
		}


        [TestMethod]
        public void RemoveFlightTest()
        {
            FlightManager manager = new FlightManager(new FakeFlightRepo());
            Flight flight1 = new Flight(1,"Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Flight flight2 = new Flight(2,"Easy Jet", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Flight flight3 = new Flight(3,"KLM", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);

            manager.AddFlight(flight1);
            manager.AddFlight(flight2);
            manager.AddFlight(flight3);
            manager.RemoveFlight(3);
            int count = manager.GetAllFlight().Count();

            Assert.AreEqual(2, count);
        }

        [TestMethod]
		public void RemoveFlight_ID_Not_Exist_ShouldThrowException()
		{
			FlightManager manager = new FlightManager(new FakeFlightRepo());
			Flight flight1 = new Flight(1, "Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);

			manager.AddFlight(flight1);

			Assert.ThrowsException<InvalidOperationException>(() => manager.RemoveFlight(3), "Cannot remove hotel");
		}

		[TestMethod]
        public void UpdateFlightTest()
        {
            FlightManager manager = new FlightManager(new FakeFlightRepo());
            Flight flight1 = new Flight(1, "Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
            Flight flightUpdated = new Flight(1, "Easy Jet", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);

            manager.AddFlight(flight1);
            manager.UpdateFlight(flightUpdated);

            Flight flight = manager.GetFlight(1);
            Assert.IsNotNull(flight);
            Assert.AreEqual("Easy Jet", flight.AirlineName);
        }

		[TestMethod]
		public void UpdateFlight_ID_Not_Exist_ShouldThrowException()
		{
			FlightManager manager = new FlightManager(new FakeFlightRepo());
			Flight flight1 = new Flight(1, "Air France", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);
			Flight flightUpdated = new Flight(3, "Easy Jet", "Paris Charles de Gaulle Airport", "France", "London Heathrow Airport", "United Kingdom", (decimal)100.00, Seats.ECONOMY, 200, (decimal)25.00);

			manager.AddFlight(flight1);

			Assert.ThrowsException<Exception>(() => manager.UpdateFlight(flightUpdated), "Cannot update hotel");
		}

	}
}
