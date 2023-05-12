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
	public class ReviewRepository : IReviewRepo
	{
		private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

		public void AddReview(Review review)
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = "INSERT INTO Reviews (HotelId, UserId, Description, Rating) " +
								   "VALUES (@HotelId, @UserId, @Description, @Rating)";
					
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@HotelId", review.HotelId);
					cmd.Parameters.AddWithValue("@UserId", review.User.UserId);
					cmd.Parameters.AddWithValue("@Description", review.Description);
					cmd.Parameters.AddWithValue("@Rating", review.Rating);

					conn.Open();
					cmd.ExecuteNonQuery();
				}

			}
			catch (SqlException)
			{
				throw new Exception("Cannot add Review");
			}
		}

		public IEnumerable<Review> GetAllReviewBasedOnHotelId(int hotelId)
		{
			try
			{
				List<Review> ReviewList = new List<Review>();

				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = @"SELECT * FROM Reviews WHERE HotelId= @HotelId; ";

					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@HotelId", hotelId);
					conn.Open();

					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						User user = new User(Convert.ToInt32(dr["3"]),
													dr["FirstName"].ToString(),
													dr["LastName"].ToString(),
													dr["Email"].ToString(),
													Convert.ToDateTime(dr["Date_of_Birth"]),
													dr["PhoneNumber"].ToString(),
													dr["Password"].ToString());

						ReviewList.Add(new Review(user,
												  Convert.ToInt32(dr["HotelId"]),
												  dr["Description"].ToString(),
												  Convert.ToInt32(dr["Rating"])));
					}
					conn.Close();
				}
				return ReviewList;

			}
			catch (SqlException)
			{
				throw new Exception("Cannot find Reviews");
			}
		}

		public IEnumerable<Review> GetAllReviewBasedOnUserdId(int userId)
		{
			throw new NotImplementedException();
		}

		public void RemoveReviewByID(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdateReview(Review review)
		{
			throw new NotImplementedException();
		}
	}
}
