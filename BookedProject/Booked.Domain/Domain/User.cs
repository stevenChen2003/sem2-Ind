using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
	public class User
	{
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public List<Booking> Bookings { get; set; }

        public User() { }

        public User(int userId,string firstName, string lastName, string email, DateTime dateOfBirth, string phoneNumber,string password)
        {
            UserId = userId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Password = password;
        }

        public User(string firstName, string lastName, string email, DateTime dateOfBirth, string phoneNumber, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            Password = password;
        }


    }
}
