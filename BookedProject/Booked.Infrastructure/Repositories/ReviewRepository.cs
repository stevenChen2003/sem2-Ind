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

        public List<Review> GetAllReviewBasedOnHotelId(int hotelId)
		{
			try
			{
				List<Review> ReviewList = new List<Review>();

				using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
					string query = @"SELECT * FROM Reviews r JOIN Users u ON r.UserId = u.UserId WHERE r.HotelId = @HotelId;";

					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@HotelId", hotelId);
					conn.Open();

					SqlDataReader dr = cmd.ExecuteReader();

					while (dr.Read())
					{
						User user = new User();
						user.UserId = Convert.ToInt32(dr["UserId"]);
						user.FirstName = dr["FirstName"].ToString();
						user.LastName = dr["LastName"].ToString();
						user.Email = dr["Email"].ToString();

						ReviewList.Add(new Review(Convert.ToInt32(dr["ReviewId"]),
												  user,
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

		public List<Review> GetAllReviewBasedOnUserdId(int userId)
		{
            try
            {
                List<Review> ReviewList = new List<Review>();

                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT * FROM Reviews r JOIN Users u ON r.UserId = u.UserId WHERE r.UserdId = @UserdId;";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserdId", userId);
                    conn.Open();

                    SqlDataReader dr = cmd.ExecuteReader();

                    while (dr.Read())
                    {
                        User user = new User();
                        user.UserId = Convert.ToInt32(dr["UserId"]);
                        user.FirstName = dr["FirstName"].ToString();
                        user.LastName = dr["LastName"].ToString();
                        user.Email = dr["Email"].ToString();

                        ReviewList.Add(new Review(Convert.ToInt32(dr["ReviewId"]),
                                                  user,
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

		public void RemoveReviewByID(int id)
		{
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "DELETE FROM Reviews WHERE ReviewId = @ReviewId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    cmd.Parameters.AddWithValue("@ReviewId", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Cannot remove review");
            }
        }

		public void UpdateReview(Review review)
		{
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "UPDATE Reviews SET Description = @Description WHERE ReviewId = @ReviewId;";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@ReviewId", review.Id);
                    command.Parameters.AddWithValue("@Description", review.Description);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new Exception("Cannot be updated");
            }
        }

        /*
        public bool CheckIfReviewExist(Review review)
        {
			try
			{
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
				{
                    string query = "SELECT COUNT(*) FROM Reviews WHERE UserId = @UserId AND HotelId = @HotelId";
					SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserId", review.User.UserId);
                    cmd.Parameters.AddWithValue("@HotelId", review.HotelId);
					conn.Open();

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
			catch
			{
				return false;
			}
        }*/

    }
}
