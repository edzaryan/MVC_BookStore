using System.ComponentModel.DataAnnotations;

namespace MVC_BookStore.Models
{
    public class SignUpUserModel
    {
        [Required(ErrorMessage = "Enter you firstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Enter your lastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter your email")]
        [Display(Name = "Email address")]
        [EmailAddress(ErrorMessage = "Please enter a valid email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Enter a strong password")]
        [Compare("ConfirmPassword", ErrorMessage = "Password does not match")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm password")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
