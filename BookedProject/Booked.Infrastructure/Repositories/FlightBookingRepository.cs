using Booked.Domain.Domain;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
	public class FlightBookingRepository : IFlightBookingRepo
	{
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

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
			throw new NotImplementedException();
		}

		public FlightBooking GetBookingById(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Booking> GetBookingByUserId(int userId)
		{
			throw new NotImplementedException();
		}

		public bool RemoveBooking(int id)
		{
			throw new NotImplementedException();
		}

		public bool UpdateBooking(FlightBooking booking)
		{
			throw new NotImplementedException();
		}
	}
}
