using System.ComponentModel.DataAnnotations;

namespace BookedWebApp.DTO
{
    public class LoginUserDTO
    {
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }


        public LoginUserDTO() { }

    }
}
