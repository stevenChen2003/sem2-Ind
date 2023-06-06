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
	public class BookingRepository : IBookingRepo
	{
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

		public void AddFlightBooking(FlightBooking booking)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					conn.Open();
					string query = "INSERT INTO Bookings (UserId, StartDate, EndDate, Price, BookingDate, Status)" +
									"OUTPUT INSERTED.BookingId " +
									"VALUES (@UserId, @StartDate, @EndDate, @Price, @BookingDate, @Status)";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@UserId", booking.User.UserId);
						cmd.Parameters.AddWithValue("@StartDate", booking.StartDate);
						cmd.Parameters.AddWithValue("@EndDate", booking.EndDate);
						cmd.Parameters.AddWithValue("@Price", booking.GetPrice());
						cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
						cmd.Parameters.AddWithValue("@Status", "Paid");

						//Gets the generated id
						booking.BookingId = (int)cmd.ExecuteScalar();
					}
					query = "INSERT INTO FlightBookings (BookingId, FlightId, ExtraLuggage)" +
							"VALUES (@BookingId, @FlightId, @ExtraLuggage)";
					using (SqlCommand cmd2 = new SqlCommand(query, conn))
					{
						cmd2.Parameters.AddWithValue("@BookingId", booking.BookingId);
						cmd2.Parameters.AddWithValue("@FlightId", booking.Flight.FlightId);
						cmd2.Parameters.AddWithValue("@ExtraLuggage", booking.ExtraLuggage);
						cmd2.ExecuteNonQuery();
					}
					conn.Close();
				}

			}
			catch (SqlException ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public void AddHotelBooking(HotelBooking hotelBooking)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					conn.Open();
					string query = "INSERT INTO Bookings (UserId, StartDate, EndDate, Price, BookingDate, Status)" +
									"OUTPUT INSERTED.BookingId " +
									"VALUES (@UserId, @StartDate, @EndDate, @Price, @BookingDate, @Status)";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@UserId", hotelBooking.User.UserId);
						cmd.Parameters.AddWithValue("@StartDate", hotelBooking.StartDate);
						cmd.Parameters.AddWithValue("@EndDate", hotelBooking.EndDate);
						cmd.Parameters.AddWithValue("@Price", hotelBooking.GetPrice());
						cmd.Parameters.AddWithValue("@BookingDate", hotelBooking.BookingDate);
						cmd.Parameters.AddWithValue("@Status", "Paid");

						//Gets the generated id
						hotelBooking.BookingId = (int)cmd.ExecuteScalar();
					}
					query = "INSERT INTO HotelBookings (BookingId, HotelId, Amount_Of_Days)" +
							"VALUES (@BookingId, @HotelId, @Amount_Of_Days)";
					using (SqlCommand cmd2 = new SqlCommand(query, conn))
					{
						cmd2.Parameters.AddWithValue("@BookingId", hotelBooking.BookingId);
						cmd2.Parameters.AddWithValue("@HotelId", hotelBooking.Hotel.HotelId);
						cmd2.Parameters.AddWithValue("@Amount_Of_Days", hotelBooking.AmountOfDays);
						cmd2.ExecuteNonQuery();
					}
					conn.Close();
				}

			}
			catch (SqlException ex)
			{
				throw new Exception(ex.Message);
			}
		}

		public IEnumerable<Booking> GetAllBooking()
		{
			List<Booking> allBookings = new List<Booking>();
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					// Retrieve flight bookings
					string flightQuery = @"SELECT b.*, fb.ExtraLuggage, f.* 
                                   FROM Bookings b
                                   INNER JOIN FlightBookings fb ON b.BookingId = fb.BookingId 
                                   INNER JOIN Flights f ON fb.FlightId = f.FlightId;";
					SqlCommand flightCmd = new SqlCommand(flightQuery, conn);

					conn.Open();
					SqlDataReader flightDr = flightCmd.ExecuteReader();

					while (flightDr.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = Convert.ToInt32(flightDr["FlightId"]);

						User user = new User();
						user.UserId = Convert.ToInt32(flightDr["UserId"]);

						allBookings.Add(new FlightBooking(Convert.ToInt32(flightDr["BookingId"]), user, (DateTime)flightDr["StartDate"], (DateTime)flightDr["EndDate"], (DateTime)flightDr["BookingDate"], flight, (bool)flightDr["ExtraLuggage"], flightDr["Status"].ToString()));
					}

					flightDr.Close();

					// Retrieve hotel bookings
					string hotelQuery = @"SELECT b.*, hb.Amount_Of_Days, h.*
                                  FROM Bookings b
                                  INNER JOIN HotelBookings hb ON b.BookingId = hb.BookingId
                                  INNER JOIN Hotels h ON hb.HotelId = h.HotelId;";
					SqlCommand hotelCmd = new SqlCommand(hotelQuery, conn);

					SqlDataReader hotelDr = hotelCmd.ExecuteReader();

					while (hotelDr.Read())
					{
						Hotel hotel = new Hotel();
						hotel.HotelId = Convert.ToInt32(hotelDr["HotelId"]);

						User user = new User();
						user.UserId = Convert.ToInt32(hotelDr["UserId"]);

						allBookings.Add(new HotelBooking(Convert.ToInt32(hotelDr["BookingId"]), user, (DateTime)hotelDr["StartDate"], (DateTime)hotelDr["EndDate"], (DateTime)hotelDr["BookingDate"], hotel, hotelDr["Status"].ToString()));
					}

					hotelDr.Close();
				}

				return allBookings;
			}
			catch (SqlException)
			{
				throw new Exception("No bookings found");
			}
		}

		public IEnumerable<Booking> GetBookingByUserId(int userId)
		{
			List<Booking> allBookings = new List<Booking>();
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					// Retrieve flight bookings
					string flightQuery = @"SELECT b.*, fb.ExtraLuggage, f.* 
                                   FROM Bookings b
                                   INNER JOIN FlightBookings fb ON b.BookingId = fb.BookingId 
                                   INNER JOIN Flights f ON fb.FlightId = f.FlightId
                                   WHERE UserId = @UserId;";
					SqlCommand flightCmd = new SqlCommand(flightQuery, conn);

					flightCmd.Parameters.AddWithValue("@UserId", userId);

					conn.Open();
					SqlDataReader flightDr = flightCmd.ExecuteReader();

					while (flightDr.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = Convert.ToInt32(flightDr["FlightId"]);
						flight.AirlineName = flightDr["Airline"].ToString();
						flight.Price = Convert.ToDecimal(flightDr["Price"]);
						flight.ExtraBaggagePrice = Convert.ToDecimal(flightDr["ExtraBaggagePrice"]);

						User user = new User();
						user.UserId = Convert.ToInt32(flightDr["UserId"]);

						allBookings.Add(new FlightBooking(Convert.ToInt32(flightDr["BookingId"]), user, (DateTime)flightDr["StartDate"], (DateTime)flightDr["EndDate"], (DateTime)flightDr["BookingDate"], flight, (bool)flightDr["ExtraLuggage"], flightDr["Status"].ToString()));
					}

					flightDr.Close();

					// Retrieve hotel bookings
					string hotelQuery = @"SELECT b.*, hb.Amount_Of_Days, h.*
                                  FROM Bookings b
                                  INNER JOIN HotelBookings hb ON b.BookingId = hb.BookingId
                                  INNER JOIN Hotels h ON hb.HotelId = h.HotelId
                                  WHERE UserId = @UserId;";
					SqlCommand hotelCmd = new SqlCommand(hotelQuery, conn);

					hotelCmd.Parameters.AddWithValue("@UserId", userId);

					SqlDataReader hotelDr = hotelCmd.ExecuteReader();

					while (hotelDr.Read())
					{
						Hotel hotel = new Hotel();
						hotel.HotelId = Convert.ToInt32(hotelDr["HotelId"]);
						hotel.Name = hotelDr["Name"].ToString();
						hotel.PricePerNight = Convert.ToDecimal(hotelDr["PricePerNight"]);

						User user = new User();
						user.UserId = Convert.ToInt32(hotelDr["UserId"]);

						allBookings.Add(new HotelBooking(Convert.ToInt32(hotelDr["BookingId"]), user, (DateTime)hotelDr["StartDate"], (DateTime)hotelDr["EndDate"], (DateTime)hotelDr["BookingDate"], hotel, hotelDr["Status"].ToString()));
					}

					hotelDr.Close();
				}

				return allBookings;
			}
			catch (SqlException)
			{
				throw new Exception("No bookings found");
			}
		}

		public Booking GetBookingById(int id)
		{
			Booking booking = null;
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string flightQuery = @"SELECT * FROM Bookings b JOIN FlightBookings fb ON b.BookingId = fb.BookingId JOIN Flights f ON fb.FlightId = f.FlightId WHERE b.BookingId = @BookingId; ";
					SqlCommand flightCmd = new SqlCommand(flightQuery, conn);

					flightCmd.Parameters.AddWithValue("@BookingId", id);

					conn.Open();
					SqlDataReader flightDr = flightCmd.ExecuteReader();

					if (flightDr.Read())
					{
						Flight flight = new Flight();
						flight.FlightId = Convert.ToInt32(flightDr["FlightId"]);
						flight.AirlineName = flightDr["Airline"].ToString();
						flight.Price = Convert.ToDecimal(flightDr["Price"]);
						flight.ExtraBaggagePrice = Convert.ToDecimal(flightDr["ExtraBaggagePrice"]);

						User user = new User();
						user.UserId = Convert.ToInt32(flightDr["UserId"]);

						booking = new FlightBooking(Convert.ToInt32(flightDr["BookingId"]), user, (DateTime)flightDr["StartDate"], (DateTime)flightDr["EndDate"], (DateTime)flightDr["BookingDate"], flight, (bool)flightDr["ExtraLuggage"], flightDr["Status"].ToString());
					}

					flightDr.Close();

					string hotelQuery = @"SELECT * FROM Bookings b JOIN HotelBookings hb ON b.BookingId = hb.BookingId JOIN Hotels h ON hb.HotelId = h.HotelId WHERE b.BookingId = @BookingId;";
					SqlCommand hotelCmd = new SqlCommand(hotelQuery, conn);

					hotelCmd.Parameters.AddWithValue("@BookingId", id);

					SqlDataReader hotelDr = hotelCmd.ExecuteReader();

					if (hotelDr.Read())
					{
						Hotel hotel = new Hotel();
						hotel.HotelId = Convert.ToInt32(hotelDr["HotelId"]);
						hotel.Name = hotelDr["Name"].ToString();
						hotel.PricePerNight = Convert.ToDecimal(hotelDr["PricePerNight"]);

						User user = new User();
						user.UserId = Convert.ToInt32(hotelDr["UserId"]);

						booking = new HotelBooking(Convert.ToInt32(hotelDr["BookingId"]), user, (DateTime)hotelDr["StartDate"], (DateTime)hotelDr["EndDate"], (DateTime)hotelDr["BookingDate"], hotel, hotelDr["Status"].ToString());
					}

					hotelDr.Close();
				}

				return booking;
			}
			catch(SqlException)
			{
				throw new Exception("No bookings found");
			}

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
				throw new Exception("Cannot remove hotel");
			}
		}

		public void UpdateBooking(Booking booking)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = "UPDATE Bookings SET Status = Canceled WHERE BookingId = @BookingId; ";
					SqlCommand command = new SqlCommand(query, conn);
					command.Parameters.AddWithValue("@BookingId", booking.BookingId);
					conn.Open();
					command.ExecuteNonQuery();
				}
			}
			catch (SqlException)
			{
				throw new Exception("Update failed");
			}
			
		}
	}
}
