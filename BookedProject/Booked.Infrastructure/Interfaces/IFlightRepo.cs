using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Interfaces
{
    public interface IFlightRepo
    {
        Flight GetFlightByID(int id);
        IEnumerable<Flight> GetAllFlight();
        void AddFlight(Flight flight);
        void UpdateHotel(Flight flight);
        void RemoveFlightByID(int id);
    }
}
