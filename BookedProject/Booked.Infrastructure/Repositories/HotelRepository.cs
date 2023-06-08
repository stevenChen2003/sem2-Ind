using Booked.Domain.Domain;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booked.Domain.Domain.Enum;
using System.Drawing;
using Booked.Logic.Interfaces;
using System.Text.RegularExpressions;
using Booked.Logic.Exceptions;
using Booked.Logic.Exceptions.HotelException;

namespace Booked.Infrastructure.Repositories
{
	public class HotelRepository : IHotelRepo
	{
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

		public Hotel GetHotelByID(int id)
		{
			Hotel DetailsHotel = new Hotel();
			try
			{
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
						Rooms roomType = (Rooms)Enum.Parse(typeof(Rooms), dr["RoomType"].ToString());
						DetailsHotel.Room = roomType;
						DetailsHotel.MaximumBooking = Convert.ToInt32(dr["MaximumBooking"]);

						byte[] imagedate = (byte[])dr["Image"];
						DetailsHotel.Image = imagedate;

					}
					conn.Close();
				}
				return DetailsHotel;
			}
			catch (SqlException ex)
			{
				throw new GetHotelException("Couldn't find hotel", ex);
			}
		}
		
		public IEnumerable<Hotel> GetAllHotel()
		{
			List<Hotel> AllHotel = new List<Hotel>();

			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = @"SELECT HotelId, Name, Address, City, Country, StarRating, PricePerNight, RoomType, MaximumBooking FROM Hotels;";

					SqlCommand cmd = new SqlCommand(query, conn);

					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						Rooms roomType = (Rooms)Enum.Parse(typeof(Rooms), dr["RoomType"].ToString());

                        AllHotel.Add(new Hotel(Convert.ToInt32(dr["HotelId"]),
													dr["Name"].ToString(),
													dr["Address"].ToString(),
													dr["City"].ToString(),
													dr["Country"].ToString(),
                                                    Convert.ToInt32(dr["StarRating"]),
													Convert.ToDecimal(dr["PricePerNight"]),
													roomType,
                                                    Convert.ToInt32(dr["MaximumBooking"])));
					}
					conn.Close();
				}
				
				return AllHotel;

			}
			catch (SqlException ex)
            {
				throw new GetHotelException("Error loading hotels", ex);
			}
		}

		public void AddHotel(Hotel hotel)
		{
			try
			{
                using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "INSERT INTO Hotels (Name, Address, City, Country, StarRating, PricePerNight, RoomType, MaximumBooking, Image) " +
                                   "VALUES (@Name, @Address, @City, @Country, @StarRating, @PricePerNight, @RoomType, @MaximumBooking, @Image )";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", hotel.Name);
                    command.Parameters.AddWithValue("@Address", hotel.Address);
                    command.Parameters.AddWithValue("@City", hotel.City);
                    command.Parameters.AddWithValue("@Country", hotel.Country);
                    command.Parameters.AddWithValue("@StarRating", hotel.StarRating);
                    command.Parameters.AddWithValue("@PricePerNight", hotel.PricePerNight);
                    command.Parameters.AddWithValue("@RoomType", hotel.Room.ToString());
                    command.Parameters.AddWithValue("@MaximumBooking", hotel.MaximumBooking);
                    command.Parameters.AddWithValue("@Image", hotel.Image);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new AddHotelException("Error adding hotel please try again", ex);
            }
        }

		public void UpdateHotel(Hotel hotel)
		{
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "UPDATE Hotels SET "+
                                    "Name = @Name, "+
                                    "Address = @Address," +
                                    "City = @City," +
                                    "Country = @Country," +
                                    "StarRating = @StarRating," +
                                    "PricePerNight = @PricePerNight," +
                                    "RoomType = @RoomType," +
                                    "MaximumBooking = @MaximumBooking," +
                                    "Image = @Image " +
                                    "WHERE HotelId = @HotelId;";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@HotelId", hotel.HotelId);
                    command.Parameters.AddWithValue("@Name", hotel.Name);
                    command.Parameters.AddWithValue("@Address", hotel.Address);
                    command.Parameters.AddWithValue("@City", hotel.City);
                    command.Parameters.AddWithValue("@Country", hotel.Country);
                    command.Parameters.AddWithValue("@StarRating", hotel.StarRating);
                    command.Parameters.AddWithValue("@PricePerNight", hotel.PricePerNight);
                    command.Parameters.AddWithValue("@RoomType", hotel.Room.ToString());
                    command.Parameters.AddWithValue("@MaximumBooking", hotel.MaximumBooking);
                    command.Parameters.AddWithValue("@Image", hotel.Image);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new UpdateHotelException("Cannot be updated", ex);
            }
        }

        public void RemoveHotelByID(int id)
        {
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = "UPDATE HotelBookings SET HotelId = NULL WHERE HotelId= @HotelId " + "DELETE FROM Hotels WHERE HotelId= @HotelId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@HotelId", id);
					cmd.ExecuteNonQuery();
                }
			}
			catch (SqlException ex)
			{
				throw new DeleteHotelException("Cannot remove hotel", ex);
            }
        }

        public int GetHotelBySearchCount(string search)
        {
			int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT COUNT(*) FROM Hotels WHERE Country LIKE @Search OR Name LIKE @Search OR City LIKE @Search ;";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Search", $"{search}%");
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        count = (int)result;
                    }
					else { count = 0; }
                    conn.Close();
                }

                return count;

            }
            catch (SqlException ex)
            {
                throw new GetHotelException("Hotels not found", ex);
            }
        }

        public int GetAllHotelCount()
        {
            int count = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT COUNT(*) FROM Hotels;";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        count = (int)result;
                    }
                    else { count = 0; }
                    conn.Close();
                }

                return count;

            }
            catch (SqlException ex)
            {
                throw new GetHotelException("Hotels not found", ex);
            }
        }

        public IEnumerable<Hotel> GetAllHotelPerPage(string sort, int itemsPerPage, int offset)
		{
			List<Hotel> AllHotel = new List<Hotel>();

			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					//Sorting
					string query = @"SELECT * FROM Hotels ";
					switch (sort)
					{
						case "name_desc":
							query += " ORDER BY Name DESC ";
							break;
						case "price_asc":
							query += " ORDER BY PricePerNight ASC ";
							break;
						case "price_desc":
							query += " ORDER BY PricePerNight DESC ";
							break;
						default:
							query += " ORDER BY Name ASC ";
							break;
					}

					//Pagination
					query += "OFFSET @Offset ROWS FETCH NEXT @ItemsPerPage ROWS ONLY;";

					SqlCommand cmd = new SqlCommand(query, conn);

					conn.Open();
					cmd.Parameters.AddWithValue("@Offset", offset);
					cmd.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						byte[] imagedate = (byte[])dr["Image"];
						Rooms roomType = (Rooms)Enum.Parse(typeof(Rooms), dr["RoomType"].ToString());

						AllHotel.Add(new Hotel(Convert.ToInt32(dr["HotelId"]),
													dr["Name"].ToString(),
													dr["Address"].ToString(),
													dr["City"].ToString(),
													dr["Country"].ToString(),
													Convert.ToInt32(dr["StarRating"]),
													Convert.ToDecimal(dr["PricePerNight"]),
													roomType,
													Convert.ToInt32(dr["MaximumBooking"]),
													imagedate));
					}
					conn.Close();
				}

				return AllHotel;

			}
			catch (SqlException ex)
			{
				throw new GetHotelException("Hotels not found", ex);
			}
		}


		public IEnumerable<Hotel> GetHotelPerPage(string search, string sort, int itemsPerPage, int offset)
		{
			List<Hotel> AllHotel = new List<Hotel>();

			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = @"SELECT * FROM Hotels WHERE Country LIKE @Search OR Name LIKE @Search OR City LIKE @Search ";
					//Sorting
					switch (sort)
					{
						case "name_desc":
							query += " ORDER BY Name DESC ";
							break;
						case "price_asc":
							query += " ORDER BY PricePerNight ASC ";
							break;
						case "price_desc":
							query += " ORDER BY PricePerNight DESC ";
							break;
						default:
							query += " ORDER BY Name ASC ";
							break;
					}

                    //Pagination
                    query += "OFFSET @Offset ROWS FETCH NEXT @ItemsPerPage ROWS ONLY;";

					SqlCommand cmd = new SqlCommand(query, conn);

					conn.Open();
					cmd.Parameters.AddWithValue("@Search", $"{search}%");
					cmd.Parameters.AddWithValue("@Offset", offset);
					cmd.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						byte[] imagedate = (byte[])dr["Image"];
						Rooms roomType = (Rooms)Enum.Parse(typeof(Rooms), dr["RoomType"].ToString());

						AllHotel.Add(new Hotel(Convert.ToInt32(dr["HotelId"]),
													dr["Name"].ToString(),
													dr["Address"].ToString(),
													dr["City"].ToString(),
													dr["Country"].ToString(),
													Convert.ToInt32(dr["StarRating"]),
													Convert.ToDecimal(dr["PricePerNight"]),
													roomType,
													Convert.ToInt32(dr["MaximumBooking"]),
													imagedate));
					}
					conn.Close();
				}

				return AllHotel;

			}
			catch (SqlException ex)
			{
				throw new GetHotelException("Hotels not found", ex);
			}

		}


    }
}
