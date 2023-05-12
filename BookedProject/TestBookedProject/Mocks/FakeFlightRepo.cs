using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBookedProject.Mocks
{
	public class FakeFlightRepo : IFlightRepo
	{
		public void AddFlight(Flight flight)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Flight> GetAllFlight()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Flight> GetAllFlights(string depart, string arrive)
		{
			throw new NotImplementedException();
		}

		public Flight GetFlightByID(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<string> GetFlightCountries()
		{
			throw new NotImplementedException();
		}

		public void RemoveFlightByID(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateHotel(Flight flight)
		{
			throw new NotImplementedException();
		}
	}
}
