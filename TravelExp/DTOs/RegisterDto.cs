using System.ComponentModel.DataAnnotations;

namespace TravelExp.DTOs
{
    public class RegisterDto
    {
        [Required, MaxLength(30)]
        public string Name { get; set; }
        [Required, MaxLength(150)]
        public string Email { get; set; }
        [Required, MaxLength(15)]
        public string Password { get; set; }
    }
}
