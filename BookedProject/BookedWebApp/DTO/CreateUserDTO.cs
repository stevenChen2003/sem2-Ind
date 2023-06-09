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
		[Required(ErrorMessage = "Date of birth is required.")]
		public DateTime DateOfBirth { get; set; }
        [Required]
        [RegularExpression(@"^\+[0-9]+$", ErrorMessage = "Invalid phone number format. Please enter a valid phone number starting with a plus sign.")]
        public string PhoneNumber { get; set; }
        [Required]
        [MinLength(7, ErrorMessage = "Password must be at least 7 characters long.")]
        public string Password { get; set; }

        public CreateUserDTO() { }

        public User GetUser()
        {
            return new User(FirstName, LastName, Email, DateOfBirth, PhoneNumber, Password);
        }

    }
}
