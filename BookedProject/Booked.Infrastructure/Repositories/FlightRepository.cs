using Booked.Domain.Domain;
using Booked.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
    public class FlightRepository : IFlightRepo
    {
        private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

        public Flight GetFlightByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Flight> GetAllFlight()
        {
            throw new NotImplementedException();
        }

        public void AddFlight(Flight flight)
        {
            throw new NotImplementedException();
        }

        public void UpdateHotel(Flight flight)
        {
            throw new NotImplementedException();
        }

        public void RemoveFlightByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
