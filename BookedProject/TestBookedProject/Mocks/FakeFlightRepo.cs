﻿using Booked.Domain.Domain;
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
		private List<Flight> flightList = new List<Flight>();

		public void AddFlight(Flight flight)
		{
			flightList.Add(flight);
		}

		public IEnumerable<Flight> GetAllFlight()
		{
			return flightList;
		}

		public IEnumerable<Flight> GetAllFlights(string depart, string arrive)
		{
            return flightList.Where(f => f.DepartureCountry == depart && f.ArrivalCountry == arrive);
        }

        public IEnumerable<Flight> GetAllFlightsPerPage(int itemsPerPage, int offset)
        {
            return flightList.Skip(offset).Take(itemsPerPage);
        }

        public Flight GetFlightByID(int id)
		{
            return flightList.FirstOrDefault(f => f.FlightId == id);
        }

		public IEnumerable<string> GetFlightCountries()
		{
            return flightList.Select(f => f.DepartureCountry).Distinct();
        }

        public IEnumerable<Flight> GetFlightsPerPage(string depart, string arrive, int itemsPerPage, int offset)
        {
            return flightList.Where(f => f.DepartureCountry == depart && f.ArrivalCountry == arrive)
            .Skip(offset)
            .Take(itemsPerPage);
        }

        public void RemoveFlightByID(int id)
		{
			try
			{
				Flight flight = GetFlightByID(id);
				if (flight == null)
				{
					throw new Exception("Error");
				}
				else
				{
					flightList.Remove(flight);
				}
			}
			catch (Exception)
			{
				throw new Exception();
			}
		}

		public void UpdateHotel(Flight flight)
		{
			try
			{
				var oldFlight = flightList.FirstOrDefault(f => f.FlightId == flight.FlightId);
				if (oldFlight != null)
				{
					oldFlight.AirlineName = flight.AirlineName;
					oldFlight.DepartureAirport = flight.DepartureAirport;
					oldFlight.DepartureCountry = flight.DepartureCountry;
					oldFlight.ArrivalAirport = flight.ArrivalAirport;
					oldFlight.ArrivalCountry = flight.ArrivalCountry;
					oldFlight.Price = flight.Price;
					oldFlight.Seat = flight.Seat;
					oldFlight.NumberOfSeats = flight.NumberOfSeats;
					oldFlight.ExtraBaggagePrice = flight.ExtraBaggagePrice;
				}
				else { throw new Exception(); }
			}
			catch (Exception) { throw new Exception("Error"); }
		}
	}
}
