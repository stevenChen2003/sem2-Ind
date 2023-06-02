using Booked.Domain.Domain;
using System.ComponentModel.DataAnnotations;

namespace BookedWebApp.DTO
{
    public class UpdateUser
    {
        public int UserId { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public UpdateUser() { }
        public UpdateUser(User user)
        {
            UserId = user.UserId;
            Email = user.Email;
            FirstName = user.FirstName;
            LastName = user.LastName;
            DateOfBirth = user.DateOfBirth;
            PhoneNumber = user.PhoneNumber;
        }

        public User GetUser()
        {
            User user = new User();
            user.UserId = UserId;
            user.Email = Email;
            user.FirstName = FirstName;
            user.LastName = LastName;
            user.DateOfBirth = DateOfBirth;
            user.PhoneNumber = PhoneNumber;
            return user;
        }

    }
}
