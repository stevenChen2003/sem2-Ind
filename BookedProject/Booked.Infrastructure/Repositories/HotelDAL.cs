using Booked.Domain.Domain;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
	public class HotelDAL
	{
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

		public static Hotel GetHotel(string Name)
		{
			Hotel DetailsHotel = new Hotel();

			using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
			{
				string query = @"SELECT * FROM MOCK_Contact_DATA WHERE Name=@fname; ";

				SqlCommand cmd = new SqlCommand(query, conn);

				conn.Open();
				cmd.Parameters.AddWithValue("@fname", Name);

				SqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					


				}
				conn.Close();
			}


			return DetailsHotel;
		}

		public IEnumerable<Hotel> GetAllHotel()
		{
			List<Hotel> DetailsHotel = new List<Hotel>();

			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = @"SELECT * FROM Hotel; ";

					SqlCommand cmd = new SqlCommand(query, conn);

					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						//DetailsHotel.Add(new Hotel() { })
					}
					conn.Close();
				}
				
				return DetailsHotel;

			}
			catch
			{
				throw new Exception("Database not working");
			}
		}

	}
}
