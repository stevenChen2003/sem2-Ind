using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Interfaces
{
    public interface IFlightRepo
    {
        Flight GetFlightByID(int id);
        IEnumerable<Flight> GetAllFlight();
        IEnumerable<Flight> GetAllFlights(string depart, string arrive);
        IEnumerable<Flight> GetFlightsPerPage(string depart, string arrive, int itemsPerPage, int offset);
		IEnumerable<Flight> GetAllFlightsPerPage(int itemsPerPage, int offset);
		void AddFlight(Flight flight);
        void UpdateHotel(Flight flight);
        void RemoveFlightByID(int id);
        IEnumerable<string> GetFlightCountries();
        //Include later the search/filter for website
    }
}
