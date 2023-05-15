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
					string query = @"SELECT b.*, hb.Amount_Of_Days, h.*
                                    FROM Bookings b
                                    INNER JOIN HotelBookings hb ON b.BookingId = hb.BookingId
                                    INNER JOIN Hotels h ON hb.HotelId = h.HotelId;";

					SqlCommand cmd = new SqlCommand(query, conn);

					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        Hotel hotel = new Hotel();
                        hotel.HotelId = Convert.ToInt32(dr["HotelId"]);
                        hotel.Name = dr["Name"].ToString();
						hotel.PricePerNight = Convert.ToDecimal(dr["PricePerNight"]);


						User user = new User();
                        user.UserId = Convert.ToInt32(dr["UserId"]);

                        AllHotelBookings.Add(new HotelBooking(Convert.ToInt32(dr["BookingId"]), user, (DateTime)dr["StartDate"], (DateTime)dr["EndDate"], (DateTime)dr["BookingDate"], hotel));
					}

				}
                return AllHotelBookings;
			}
            catch (SqlException)
			{
                throw new Exception("No bookings found");
            }
        }

        public IEnumerable<Booking> GetAllBookingByUserId(int userId)
        {
			List<Booking> AllHotelBookings = new List<Booking>();
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = @"SELECT b.*, hb.Amount_Of_Days, h.*
                                    FROM Bookings b
                                    INNER JOIN HotelBookings hb ON b.BookingId = hb.BookingId
                                    INNER JOIN Hotels h ON hb.HotelId = h.HotelId
                                    WHERE UserId = @UserId;";

					SqlCommand cmd = new SqlCommand(query, conn);
					
                    conn.Open();
					cmd.Parameters.AddWithValue("@UserId", userId);

					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						Hotel hotel = new Hotel();
						hotel.HotelId = Convert.ToInt32(dr["HotelId"]);
						hotel.Name = dr["Name"].ToString();
						hotel.PricePerNight = Convert.ToDecimal(dr["PricePerNight"]);


						User user = new User();
						user.UserId = Convert.ToInt32(dr["UserId"]);

						AllHotelBookings.Add(new HotelBooking(Convert.ToInt32(dr["BookingId"]), user, (DateTime)dr["StartDate"], (DateTime)dr["EndDate"], (DateTime)dr["BookingDate"], hotel));
					}

				}
				return AllHotelBookings;
			}
			catch (SqlException)
			{
				throw new Exception("No bookings found");
			}
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
                    query = "INSERT INTO HotelBookings (BookingId, HotelId, Amount_Of_Days)" +
							"VALUES (@BookingId, @HotelId, @Amount_Of_Days)";
					using (SqlCommand cmd2 = new SqlCommand(query, conn))
					{
						cmd2.Parameters.AddWithValue("@BookingId", b.BookingId);
						cmd2.Parameters.AddWithValue("@HotelId", b.Hotel.HotelId);
						cmd2.Parameters.AddWithValue("@Amount_Of_Days", b.AmountOfDays);
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


        //Use for cancel maybe?, work on it later
        public void UpdateBooking(HotelBooking booking)
        {
            throw new NotImplementedException();
        }

    }
}
