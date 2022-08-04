using System.ComponentModel.DataAnnotations;

namespace DEZ_System_API.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "User Name is Required")]
        public string? Username { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string? EmailAddress { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public string? Password { get; set; }
    }
}
