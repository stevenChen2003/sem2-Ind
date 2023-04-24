using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT * FROM Flights WHERE FlightId = @FlightId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@FlightId", id);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        Flight flightDetails = new Flight(Convert.ToInt32(dr["FlightId"]),
                                                  dr["Airline"].ToString(),
                                                  dr["DepartureAirport"].ToString(),
                                                  dr["DepartureCountry"].ToString(),
                                                  dr["ArrivalAirport"].ToString(),
                                                  dr["ArrivalCountry"].ToString(),
                                                  Convert.ToDecimal(dr["Price"]),
                                                  (Seats)Enum.Parse(typeof(Seats), dr["SeatType"].ToString()),
                                                  Convert.ToInt32(dr["NumberOfSeats"]),
                                                  Convert.ToDecimal(dr["ExtraBaggagePrice"]));
                        return flightDetails;
                    }
                    conn.Close();
                }
                return null;
            }
            catch (Exception)
            {
                throw new Exception("Flight not found");
            }
        }

        public IEnumerable<Flight> GetAllFlight()
        {
            List<Flight> ListFlights = new List<Flight>();
            try
            {
                using(SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT * FROM Flights; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Flight flightDetails = new Flight(Convert.ToInt32(dr["FlightId"]),
                                                  dr["Airline"].ToString(),
                                                  dr["DepartureAirport"].ToString(),
                                                  dr["DepartureCountry"].ToString(),
                                                  dr["ArrivalAirport"].ToString(),
                                                  dr["ArrivalCountry"].ToString(),
                                                  Convert.ToDecimal(dr["Price"]),
                                                  (Seats)Enum.Parse(typeof(Seats), dr["SeatType"].ToString()),
                                                  Convert.ToInt32(dr["NumberOfSeats"]),
                                                  Convert.ToDecimal(dr["ExtraBaggagePrice"]));
                        ListFlights.Add(flightDetails);
                    }
                    conn.Close();
                }
                return ListFlights;
            }
            catch (Exception)
            {
                throw new Exception("Not Flights found");
            }
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
