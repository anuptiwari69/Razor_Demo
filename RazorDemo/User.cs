using System.ComponentModel.DataAnnotations;

namespace RazorDemo
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,20}$", ErrorMessage = "Create Alphanumeric Password  With Special  Characters ")]
        public string Password { get; set; }

    }
}

