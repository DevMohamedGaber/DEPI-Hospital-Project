﻿using System.ComponentModel.DataAnnotations;

namespace Presentation.ViewModels
{
    public class SignInViewModel
    {
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
