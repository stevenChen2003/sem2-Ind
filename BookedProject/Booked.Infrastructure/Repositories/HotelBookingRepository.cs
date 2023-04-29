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
                    string query = "INSERT INTO ";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        
                    }
                    query = "";
					using (SqlCommand cmd2 = new SqlCommand(query, conn))
					{

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
