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
    public class HotelBookingRepository : IHotelBookingRepo
    {
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

		public IEnumerable<Booking> GetAllBooking()
        {
            List<Booking> AllHotelBookings = new List<Booking>();
            try
            {
                //Need to finish this part
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
					string query = @"SELECT * FROM Bookings; ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {

                    }

                }
                return AllHotelBookings;
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


        public HotelBooking GetBookingById(int id)
        {
            throw new NotImplementedException();
        }

        public void AddBooking(HotelBooking b)
        {
            try
            {
                using(SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    string query = "INSERT INTO Bookings (UserId, StartDate, EndDate, Price, BookingDate)" +
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
                    query = "INSERT INTO HotelBookings (BookingId, HotelId, Amount_Of_Days)" +
							"VALUES (@BookingId, @HotelId, @Amount_Of_Days)"; ;
					using (SqlCommand cmd2 = new SqlCommand(query, conn))
					{
						cmd2.Parameters.AddWithValue("@BookingId", b.BookingId);
						cmd2.Parameters.AddWithValue("@HotelId", b.Hotel.HotelId);
						cmd2.Parameters.AddWithValue("@Amount_Of_Days", b.AmountOfDays);
					}
					conn.Close();
                }

            }
            catch (SqlException)
            {
				throw new Exception("Cannot add Booking");
			}
        }

        public bool RemoveBooking(int id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateBooking(HotelBooking booking)
        {
            throw new NotImplementedException();
        }

    }
}
