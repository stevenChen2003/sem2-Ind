using Booked.Domain.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
	public class Flight
	{
		public int FlightId { get; set; }
		public string AirlineName { get; set; }
		public string DepatureAirport { get; set; }	
		public string DepatureCountry { get; set; }
		public string ArrivalAirport { get; set; }
		public string ArrivalCountry { get; set; }
		public decimal Price { get; set; }
		public Seats Seat { get; set; }
		public int NumberOfSeats { get; set; }
		public decimal ExtraBaggagePrice { get; set; }


		public Flight() { }

		//Constructor with ID
		public Flight(int flightId, string airline, string departureAirport, string departureCountry, string arrivalAirport, string arrivalCountry, decimal price, Seats seat, int numberOfSeats, decimal extraBaggagePrice)
		{
			FlightId = flightId;
			AirlineName = airline;
			DepatureAirport = departureAirport;
			DepatureCountry = departureCountry;
			ArrivalAirport = arrivalAirport;
			ArrivalCountry = arrivalCountry;
			Price = price;
			Seat = seat;
			NumberOfSeats = numberOfSeats;
			ExtraBaggagePrice = extraBaggagePrice;
		}

		//Constructor without ID
        public Flight(string airline, string departureAirport, string departureCountry, string arrivalAirport, string arrivalCountry, decimal price, Seats seat, int numberOfSeats, decimal extraBaggagePrice)
        {
            AirlineName = airline;
            DepatureAirport = departureAirport;
			DepatureCountry = departureCountry;
            ArrivalAirport = arrivalAirport;
			ArrivalCountry = arrivalCountry;
            Price = price;
            Seat = seat;
            NumberOfSeats = numberOfSeats;
            ExtraBaggagePrice = extraBaggagePrice;
        }
    }
}
