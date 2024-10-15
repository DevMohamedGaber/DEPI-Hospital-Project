using Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Presentation.ViewModels
{
    public class SignUpViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmedPassword { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public Gender Gender { get; set; }

        public string SocialNumber { get; set; }
        public int Role { get; set; }

        public bool IsAgree { get; set; }

    }
}
