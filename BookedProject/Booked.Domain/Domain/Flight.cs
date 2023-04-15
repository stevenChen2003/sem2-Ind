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
		public string Airline { get; set; }
		public string DepatureAirport { get; set; }	
		public string ArrivalAirport { get; set; }
		public decimal Price { get; set; }
		public Seats Seat { get; set; }
		public int NumberOfSeats { get; set; }
		public decimal ExtraBaggagePrice { get; set; }

		//Need to start working on this 
		public Flight() { }
	}
}
