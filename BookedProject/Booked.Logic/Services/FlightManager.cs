using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Logic.Services
{
    public class FlightManager
    {
        private IFlightRepo flightRepo;

        public FlightManager(IFlightRepo repo)
        {
            flightRepo = repo;
        }

        public Flight GetFlight(int id)
        {
            return flightRepo.GetFlightByID(id);
        }

        public IEnumerable<Flight> GetAllFlight()
        {
            return flightRepo.GetAllFlight();
        }

        public void AddFlight(Flight flight)
        {
            try
            {
                flightRepo.AddFlight(flight);
            }
            catch(Exception)
            {
                throw new Exception("Adding not succesfull");
            }
        }


        public void UpdateFlight(Flight flight)
        {
            try
            {
                flightRepo.UpdateHotel(flight);
            }
            catch(Exception)
            {
                throw new Exception("Cannot update flight information");
            }
        }

        public void RemoveFlight(int id)
        {
            try
            {
                flightRepo.RemoveFlightByID(id);
            }
            catch (Exception)
            {
                throw new Exception("Cannot remove hotel");
            }
        }

        public IEnumerable<string> GetCountries()
        {
            return flightRepo.GetFlightCountries();
        }

    }
}
