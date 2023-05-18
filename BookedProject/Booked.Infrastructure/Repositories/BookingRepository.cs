﻿using Booked.Domain.Domain;
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
					string query = "INSERT INTO Bookings (UserId, StartDate, EndDate, Price, BookingDate)" +
									"OUTPUT INSERTED.BookingId " +
									"VALUES (@UserId, @StartDate, @EndDate, @Price, @BookingDate)";
					using (SqlCommand cmd = new SqlCommand(query, conn))
					{
						cmd.Parameters.AddWithValue("@UserId", booking.User.UserId);
						cmd.Parameters.AddWithValue("@StartDate", booking.StartDate);
						cmd.Parameters.AddWithValue("@EndDate", booking.EndDate);
						cmd.Parameters.AddWithValue("@Price", booking.GetPrice());
						cmd.Parameters.AddWithValue("@BookingDate", booking.BookingDate);

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
			catch (SqlException)
			{
				throw new Exception("Cannot add Booking");
			}
		}

		public void AddHotelBooking(HotelBooking hotelBooking)
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
						cmd.Parameters.AddWithValue("@UserId", hotelBooking.User.UserId);
						cmd.Parameters.AddWithValue("@StartDate", hotelBooking.StartDate);
						cmd.Parameters.AddWithValue("@EndDate", hotelBooking.EndDate);
						cmd.Parameters.AddWithValue("@Price", hotelBooking.GetPrice());
						cmd.Parameters.AddWithValue("@BookingDate", hotelBooking.BookingDate);

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
			catch (SqlException)
			{
				throw new Exception("Cannot add Booking");
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
						flight.AirlineName = flightDr["Airline"].ToString();
						flight.Price = Convert.ToDecimal(flightDr["Price"]);
						flight.ExtraBaggagePrice = Convert.ToDecimal(flightDr["ExtraBaggagePrice"]);

						User user = new User();
						user.UserId = Convert.ToInt32(flightDr["UserId"]);

						allBookings.Add(new FlightBooking(Convert.ToInt32(flightDr["BookingId"]), user, (DateTime)flightDr["StartDate"], (DateTime)flightDr["EndDate"], (DateTime)flightDr["BookingDate"], flight, (bool)flightDr["ExtraLuggage"]));
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
						hotel.Name = hotelDr["Name"].ToString();
						hotel.PricePerNight = Convert.ToDecimal(hotelDr["PricePerNight"]);

						User user = new User();
						user.UserId = Convert.ToInt32(hotelDr["UserId"]);

						allBookings.Add(new HotelBooking(Convert.ToInt32(hotelDr["BookingId"]), user, (DateTime)hotelDr["StartDate"], (DateTime)hotelDr["EndDate"], (DateTime)hotelDr["BookingDate"], hotel));
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

						allBookings.Add(new FlightBooking(Convert.ToInt32(flightDr["BookingId"]), user, (DateTime)flightDr["StartDate"], (DateTime)flightDr["EndDate"], (DateTime)flightDr["BookingDate"], flight, (bool)flightDr["ExtraLuggage"]));
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

						allBookings.Add(new HotelBooking(Convert.ToInt32(hotelDr["BookingId"]), user, (DateTime)hotelDr["StartDate"], (DateTime)hotelDr["EndDate"], (DateTime)hotelDr["BookingDate"], hotel));
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
			throw new NotImplementedException();
		}

		public void RemoveBooking(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateBooking(Booking booking)
		{
			throw new NotImplementedException();
		}
	}
}