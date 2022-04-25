using System.ComponentModel.DataAnnotations;

namespace RazForm.Entities
{
    public class Account
    {
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Username { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        public string Userslogin { get; set; }

        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%]).{6,20})")]
        public string Password { get; set; }

        [Range(18, 120)]
        public int Age { get; set; }

       
        [EmailAddress]
        public string Email { get; set; }

        [Url]
        public string Portfolio { get; set; }
    }
}