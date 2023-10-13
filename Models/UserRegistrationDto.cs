using System.ComponentModel.DataAnnotations;

namespace Laboratorium8.Models
{
    public class UserRegistrationDto
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}

