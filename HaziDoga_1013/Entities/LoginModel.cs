using System.ComponentModel.DataAnnotations;

namespace HaziDoga_1013.Entities
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }

}
