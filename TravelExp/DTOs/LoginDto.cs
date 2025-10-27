using System.ComponentModel.DataAnnotations;

namespace TravelExp.DTOs
{
    public class LoginDto
    {
        [Required]
        public string Email { get; set; }
        [Required, MaxLength(15)]
        public string Password { get; set; }
    }
}
