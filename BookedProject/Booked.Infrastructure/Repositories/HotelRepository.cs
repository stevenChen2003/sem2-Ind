﻿using Booked.Domain.Domain;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booked.Domain.Domain.Enum;
using System.Drawing;
using Booked.Logic.Interfaces;

namespace Booked.Infrastructure.Repositories
{
	public class HotelRepository : IHotelRepo
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
			catch (SqlException)
            {
				throw new Exception("Hotels not found");
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
            catch (SqlException)
            {
                throw new Exception("Cannot add hotel");
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
            catch (Exception)
            {
                throw new Exception("Cannot be updated");
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
			catch (SqlException)
			{
				throw new Exception("Cannot remove hotel");
            }
        }

        public IEnumerable<Hotel> GetAllHotelBySearch(string search, string sort)
        {
            List<Hotel> AllHotel = new List<Hotel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT * FROM Hotels WHERE Country LIKE @Search OR Name LIKE @Search OR City LIKE @Search ";

                    switch (sort)
                    {
                        case "name_desc":
                            query += " ORDER BY Name DESC;";
                            break;
                        case "price_asc":
                            query += " ORDER BY PricePerNight ASC;";
                            break;
                        case "price_desc":
                            query += " ORDER BY PricePerNight DESC;";
                            break;
                        default:
                            query += " ORDER BY Name ASC;";
                            break;
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@Search", $"{search}%");
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
            catch (SqlException)
            {
                throw new Exception("Hotels not found");
            }
        }

        public IEnumerable<Hotel> GetAllWebsiteHotel(string sort)
        {
            List<Hotel> AllHotel = new List<Hotel>();

            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT * FROM Hotels ";

                    switch (sort)
                    {
                        case "name_desc":
                            query += " ORDER BY Name DESC;";
                            break;
                        case "price_asc":
                            query += " ORDER BY PricePerNight ASC;";
                            break;
                        case "price_desc":
                            query += " ORDER BY PricePerNight DESC;";
                            break;
                        default:
                            query += " ORDER BY Name ASC;";
                            break;
                    }

                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
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
            catch (SqlException)
            {
                throw new Exception("Hotels not found");
            }
        }
    }
}
