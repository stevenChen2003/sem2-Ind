using Booked.Domain.Domain;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
	public class HotelRepository
	{
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

		public Hotel GetHotelByID(int id)
		{
			Hotel DetailsHotel = new Hotel();

			using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
			{
				string query = @"SELECT * FROM Hotels WHERE HotelId= @HotelId; ";

				SqlCommand cmd = new SqlCommand(query, conn);

				conn.Open();
				cmd.Parameters.AddWithValue("@HotelId", id);

				SqlDataReader dr = cmd.ExecuteReader();

				while (dr.Read())
				{
					DetailsHotel.HotelId = Convert.ToInt32(dr["HotelId"]);
					DetailsHotel.Name = dr["Name"].ToString();
					DetailsHotel.Address = dr["Address"].ToString();
					DetailsHotel.City = dr["City"].ToString();
					DetailsHotel.Country = dr["Country"].ToString();
					DetailsHotel.StarRating = Convert.ToInt32(dr["StarRating"]);
					DetailsHotel.PricePerNight = Convert.ToDecimal(dr["PricePerNight"]);
					byte[] imagedate = (byte[])dr["Image"];
					DetailsHotel.Image = imagedate;

                }
				conn.Close();
			}
			return DetailsHotel;
		}
		
		public IEnumerable<Hotel> GetAllHotel()
		{
			List<Hotel> AllHotel = new List<Hotel>();

			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = @"SELECT * FROM Hotels; ";

					SqlCommand cmd = new SqlCommand(query, conn);

					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						byte[] imagedate = (byte[])dr["Image"];
						AllHotel.Add(new Hotel(Convert.ToInt32(dr["HotelId"]),
													dr["Name"].ToString(),
													dr["Address"].ToString(),
													dr["City"].ToString(),
													dr["Country"].ToString(),
                                                    Convert.ToInt32(dr["StarRating"]),
													Convert.ToDecimal(dr["PricePerNight"]),
                                                    imagedate));
					}
					conn.Close();
				}
				
				return AllHotel;

			}
			catch (Exception)
            {
				throw new Exception("Hotels not found");
			}
		}


		//Need to make Add, Remove and Update methods
		public void AddHotel(Hotel hotel)
		{
			try
			{
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "INSERT INTO Hotels (Name, Address, City, Country, StarRating, PricePerNight, Image) " +
                                   "VALUES (@Name, @Address, @City, @Country, @StarRating, @PricePerNight, @Image )";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", hotel.Name);
                    command.Parameters.AddWithValue("@Address", hotel.Address);
                    command.Parameters.AddWithValue("@City", hotel.City);
                    command.Parameters.AddWithValue("@Country", hotel.Country);
                    command.Parameters.AddWithValue("@StarRating", hotel.StarRating);
                    command.Parameters.AddWithValue("@PricePerNight", hotel.PricePerNight);
                    command.Parameters.AddWithValue("@Image", hotel.Image);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Cannot add hotel");
            }
        }

		public void UpdateHotel(Hotel hotel)
		{

		}

        public void RemoveHotelByID(int id)
        {
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = "DELETE FROM Hotels WHERE HotelId= @HotelId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@HotelId", id);
					cmd.ExecuteNonQuery();
                }
			}
			catch (SqlException)
			{
				throw new Exception("Cannot remove hotel");
            }
        }

    }
}
