﻿using Booked.Domain.Domain;
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
					string query = @"SELECT * FROM Hotels; ";

					SqlCommand cmd = new SqlCommand(query, conn);

					conn.Open();
					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						DetailsHotel.Add(new Hotel(Convert.ToInt32(dr["HotelId"]),
													dr["Name"].ToString(),
													dr["Address"].ToString(),
													dr["City"].ToString(),
													dr["Country"].ToString(),
                                                    Convert.ToInt32(dr["StarRating"]),
													Convert.ToDecimal(dr["PricePerNight"])));
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


		//Need to make Add, Remove and Update methods
		public void AddHotel(Hotel hotel)
		{

		}

		public void RemoveHotelByID(int id)
		{

		}

		public void UpdateHotelByID(int id)
		{

		}

	}
}