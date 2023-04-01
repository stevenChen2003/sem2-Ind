using Booked.Domain.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
	public class UserRepository
	{
        private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

        public User GetUserByID(int id)
        {
            User DetailUser = new User();

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = @"SELECT * FROM Users WHERE UserId= @UserId; ";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@UserId", id);

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    DetailUser.UserId = Convert.ToInt32(dr["UserId"]);
                    DetailUser.FirstName = dr["FirstName"].ToString();
                    DetailUser.LastName = dr["LastName"].ToString();
                    DetailUser.Email = dr["Email"].ToString();
                    DetailUser.Password = dr["Password"].ToString();
                }
                conn.Close();
            }
            return DetailUser;
        }

        public IEnumerable<User> GetAllUser()
        {
            List<User> AllUsers = new List<User>();
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = @"SELECT * FROM Users; ";
                    
                    SqlCommand cmd = new SqlCommand(query, conn);

                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        AllUsers.Add(new User(Convert.ToInt32(dr["UserId"]),
                                                    dr["FirstName"].ToString(),
                                                    dr["LastName"].ToString(),
                                                    dr["Email"].ToString(),
                                                    dr["Password"].ToString()));
                    }
                    conn.Close();
                }

                return AllUsers;
            }
            catch
            {
                throw new Exception("Error");
            }
        }

        //Need to make Add, Remove and Update methods
        public void AddUser(User user)
        {
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                string query = "INSERT INTO Users (FirstName, LastName, Email, Password) " +
                               "VALUES (@FirstName, @LastName, @Email, @Password)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@FirstName", user.FirstName);
                command.Parameters.AddWithValue("@LastName", user.LastName);
                command.Parameters.AddWithValue("@Email", user.Email);
                //.Parameters.AddWithValue("@Salt", salt);
                command.Parameters.AddWithValue("@Password", user.Password);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void UpdateUser(User user)
        {

        }

        public void RemoveUserByID(int id)
        {

        }

        public User FindUserByEmail(string email)
        {
            User DetailUser = new User();

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = @"SELECT * FROM Users WHERE Email= @Email; ";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@Email", email);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    DetailUser.UserId = Convert.ToInt32(dr["UserId"]);
                    DetailUser.FirstName = dr["FirstName"].ToString();
                    DetailUser.LastName = dr["LastName"].ToString();
                    DetailUser.Email = dr["Email"].ToString();
                    DetailUser.Password = dr["Password"].ToString();
                }

                else { DetailUser = null; }
                conn.Close();
            }
            return DetailUser;
        }

        public string GetHashedAndSaltPassword(string email)
        {
            string hashedPassword = "";

            using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
            {
                string query = @"SELECT Password FROM Users WHERE Email= @Email; ";

                SqlCommand cmd = new SqlCommand(query, conn);

                conn.Open();
                cmd.Parameters.AddWithValue("@Email", email);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    hashedPassword = dr["Password"].ToString();
                }

                else
                {
                    hashedPassword= null;
                }
                conn.Close();
            }
            return hashedPassword;
        }

    }
}
