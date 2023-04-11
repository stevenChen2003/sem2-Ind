using System.ComponentModel.DataAnnotations;

namespace BookedWebApp.DTO
{
    public class UpdateUser
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public UpdateUser() { }
    }
}
