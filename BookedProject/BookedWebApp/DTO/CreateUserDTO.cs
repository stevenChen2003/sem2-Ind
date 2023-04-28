using Booked.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace BookedWebApp.DTO
{
    public class CreateUserDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }

        public CreateUserDTO() { }

        public User GetUser()
        {
            return new User(FirstName, LastName, Email, DateOfBirth, PhoneNumber, Password);
        }

    }
}
