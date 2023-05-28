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
            try
            {
				return flightRepo.GetAllFlight();
			}
            catch (Exception)
            {
                throw new Exception("Database not connected");
            }
        }

        public void AddFlight(Flight flight)
        {
            try
            {
                if (CheckIfFlightExist(flight))
                {
					throw new InvalidOperationException("Flight already exist");
				}
                else
                {
					flightRepo.AddFlight(flight);
				}
            }
            catch(InvalidOperationException i)
            {
                throw new InvalidOperationException(i.Message);
			}
        }

        public bool CheckIfFlightExist(Flight flight)
        {
            foreach (Flight f in flightRepo.GetAllFlight())
            {
                if (f.AirlineName == flight.AirlineName && f.DepartureAirport == flight.DepartureAirport && f.ArrivalAirport == flight.ArrivalAirport && f.Seat == flight.Seat)
                {
                    return true;
                }
            }
            return false;
        }

        public void UpdateFlight(Flight flight)
        {
            try
            {
                flightRepo.UpdateHotel(flight);
            }
            catch(Exception)
            {
                throw new InvalidOperationException("Cannot update flight information");
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
                throw new InvalidOperationException("Cannot remove flight");
            }
        }

        //For displaying
        public IEnumerable<string> GetCountries()
        {
            return flightRepo.GetFlightCountries();
        }

        
        public IEnumerable<Flight> GetFlightsBySearch(string depart, string arrive, int itemsPerPage, int offset)
        {
            if (!string.IsNullOrEmpty(depart) && !string.IsNullOrEmpty(arrive))
            {
                return flightRepo.GetFlightsPerPage(depart, arrive, itemsPerPage, offset);
            }
            else
            {
                return flightRepo.GetAllFlightsPerPage(itemsPerPage, offset);
            }
        }

        public int GetTotalFlightsCount(string depart, string arrive)
        {
			if (!string.IsNullOrEmpty(depart) && !string.IsNullOrEmpty(arrive))
			{
				return flightRepo.GetAllFlights(depart, arrive).Count();
			}
			else
			{
				return flightRepo.GetAllFlight().Count();
			}
		}

	}
}
