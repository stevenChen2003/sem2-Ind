﻿using Booked.Domain.Domain;
using Booked.Domain.Domain.Enum;
using Booked.Logic.Exceptions;
using Booked.Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Infrastructure.Repositories
{
	public class UserRepository : IUserRepo
	{
        private const string CONNECTION_STRING = @"Server=mssqlstud.fhict.local;Database=dbi507678_booked;User Id=dbi507678_booked;Password=booked789;";

        public User FindUserByEmail(string email)
        {
            User DetailUser = new User();
            try
            {
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
						DetailUser.DateOfBirth = Convert.ToDateTime(dr["Date_of_Birth"]);
						DetailUser.PhoneNumber = dr["PhoneNumber"].ToString();
						DetailUser.Password = dr["Password"].ToString();
                        DetailUser.UserType = (UserType)Enum.Parse(typeof(UserType), dr["Type"].ToString());
                    }

					else { DetailUser = null; }
					conn.Close();
				}
				return DetailUser;
			}
            catch (SqlException ex)
            {
                throw new GetException("Error finding user",ex);
            }
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
                                                    Convert.ToDateTime(dr["Date_of_Birth"]),
                                                    dr["PhoneNumber"].ToString(),
                                                    dr["Password"].ToString(),
                                                    (UserType)Enum.Parse(typeof(UserType), dr["Type"].ToString())));
                    }
                    conn.Close();
                }

                return AllUsers;
            }
            catch (SqlException ex)
            {
                throw new GetException("No users found", ex);
            }
        }

        public void AddUser(User user)
        {
            try
            {
				using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
				{
					string query = "INSERT INTO Users (FirstName, LastName, Email, Date_of_Birth, PhoneNumber, Password, Type) " +
                                   "VALUES (@FirstName, @LastName, @Email, @Date_of_Birth, @PhoneNumber, @Password, @Type)";

					SqlCommand command = new SqlCommand(query, connection);
					command.Parameters.AddWithValue("@FirstName", user.FirstName);
					command.Parameters.AddWithValue("@LastName", user.LastName);
					command.Parameters.AddWithValue("@Email", user.Email);
					command.Parameters.AddWithValue("@Date_of_Birth", user.DateOfBirth);
					command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
					command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Type", user.UserType.ToString());
					connection.Open();
					command.ExecuteNonQuery();
				}
			}
            catch (SqlException ex)
            {
				throw new AddingException("Couldn't add user", ex);
			}
        }

        public void UpdateUser(User user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "UPDATE Users SET FirstName = @FirstName, LastName = @LastName, Date_of_Birth = @Date_of_Birth, PhoneNumber = @PhoneNumber WHERE Email= @Email; ";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@FirstName", user.FirstName);
                    command.Parameters.AddWithValue("@LastName", user.LastName);
                    command.Parameters.AddWithValue("@Email", user.Email);
                    command.Parameters.AddWithValue("@Date_of_Birth", user.DateOfBirth);
                    command.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber);
                    conn.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new UpdateException("Cannot be updated", ex);
            }
        }

        public void RemoveUserByID(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(CONNECTION_STRING))
                {
                    string query = "DELETE FROM Users WHERE UserId= @UserId; ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@UserId", id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                throw new DeleteException("Cannot remove User", ex);
            }
        }

        public string GetHashedAndSaltPassword(string email)
        {
            string hashedPassword = "";
            try
            {
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
						hashedPassword = null;
					}
					conn.Close();
				}
				return hashedPassword;
			}
            catch (SqlException ex)
			{
                throw new GetException("Error logging in", ex);
            }
        }

    }
}
