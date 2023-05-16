using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
	public class FlightBookingRepository : IFlightBookingRepo
	{
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";


        string query = "SELECT b.*, fb.ExtraLuggage, f.* FROM Bookings b INNER JOIN FlightBookings fb ON b.BookingId = fb.BookingId INNER JOIN Flights f ON fb.FlightId = f.FlightId;";

        public void AddBooking(FlightBooking b)
		{
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    string query = "INSERT INTO Bookings (UserId, StartDate, EndDate, Price, BookingDate)" +
                                    "OUTPUT INSERTED.BookingId " +
                                    "VALUES (@UserId, @StartDate, @EndDate, @Price, @BookingDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", b.User.UserId);
                        cmd.Parameters.AddWithValue("@StartDate", b.StartDate);
                        cmd.Parameters.AddWithValue("@EndDate", b.EndDate);
                        cmd.Parameters.AddWithValue("@Price", b.GetPrice());
                        cmd.Parameters.AddWithValue("@BookingDate", b.BookingDate);

                        //Gets the generated id
                        b.BookingId = (int)cmd.ExecuteScalar();
                    }
                    query = "INSERT INTO FlightBookings (BookingId, FlightId, ExtraLuggage)" +
                            "VALUES (@BookingId, @FlightId, @ExtraLuggage)";
                    using (SqlCommand cmd2 = new SqlCommand(query, conn))
                    {
                        cmd2.Parameters.AddWithValue("@BookingId", b.BookingId);
                        cmd2.Parameters.AddWithValue("@HotelId", b.Flight.FlightId);
                        cmd2.Parameters.AddWithValue("@ExtraLuggage", b.ExtraLuggage);
                        cmd2.ExecuteNonQuery();
                    }
                    conn.Close();
                }

            }
            catch (SqlException)
            {
                throw new Exception("Cannot add Booking");
            }
        }

		public IEnumerable<Booking> GetAllBooking()
		{
            List<Booking> AllFlightBookings = new List<Booking>();
            try
            {
                //Need to finish this part
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT b.*, fb.ExtraLuggage, f.* FROM Bookings 
                                     b INNER JOIN FlightBookings fb ON b.BookingId = fb.BookingId 
                                     INNER JOIN Flights f ON fb.FlightId = f.FlightId;";

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Flight flight = new Flight();
                        flight.FlightId = Convert.ToInt32(dr["FlightId"]);
                        flight.AirlineName = dr["Airline"].ToString();
                        flight.Price = Convert.ToDecimal(dr["Price"]);
                        flight.ExtraBaggagePrice = Convert.ToDecimal(dr["ExtraBaggagePrice"]);

                        User user = new User();
                        user.UserId = Convert.ToInt32(dr["UserId"]);

                        AllFlightBookings.Add(new FlightBooking(Convert.ToInt32(dr["BookingId"]), user, (DateTime)dr["StartDate"], (DateTime)dr["EndDate"], (DateTime)dr["BookingDate"], flight, (bool)dr["ExtraLuggage"]));
                    }

                }
                return AllFlightBookings;
            }
            catch (SqlException)
            {
                throw new Exception("No bookings found");
            }
        }

		public IEnumerable<Booking> GetBookingByUserId(int userId)
		{
			throw new NotImplementedException();
		}
		public FlightBooking GetBookingById(int id)
		{
			throw new NotImplementedException();
		}

		public void RemoveBooking(int id)
		{
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "DELETE FROM Bookings WHERE BookingId = @BookingId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@BookingId", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Cannot remove");
            }
        }

		public void UpdateBooking(FlightBooking booking)
		{
			throw new NotImplementedException();
		}
	}
}
