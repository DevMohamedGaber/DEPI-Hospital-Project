using Application.Interfaces;
using DataAccess.Abstacts;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Shared.DTO;

namespace Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole<uint>> _roleManager;

        public AuthenticationService(UserManager<User> userManager, 
            SignInManager<User> signInManager, 
            RoleManager<IdentityRole<uint>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public async Task<List<ErrorViewModel>> SignUp(SignUpViewModel signUpViewModel)
        {
            var errors = new List<ErrorViewModel>();

            var user = await _userManager.FindByNameAsync(signUpViewModel.FirstName + "" + signUpViewModel.LastName);

            if (user == null)
            {
                string role = null;
                user = new User
                {
                    firstName = signUpViewModel.FirstName,
                    lastName = signUpViewModel.LastName,
                    UserName = signUpViewModel.FirstName + "" + signUpViewModel.LastName,
                    Email = signUpViewModel.Email,
                    PhoneNumber = signUpViewModel.PhoneNumber,
                    Address = signUpViewModel.Address,
                    gender = signUpViewModel.Gender,
                    IsAgree = signUpViewModel.IsAgree,

                };
                switch (signUpViewModel.Role)
                {
                    case 1:
                        var Admin = (Admin)user;
                        user = Admin;
                        role = "ADMIN";
                        break;
                    case 2:
                        var Doctor = (Doctor)user;
                        user = Doctor;
                        role = "DOCTOR";
                        break;
                    case 3:
                        var Nurse = (Nurse)user;
                        user = Nurse;
                        role = "Nurse";
                        break;
                    case 4:
                        var Patient = (Patient)user;
                        user = Patient;
                        role = "Pastient";
                        break;
                }

                var result = await _userManager.CreateAsync(user, signUpViewModel.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, role);
                    return null;
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        errors.Add(new ErrorViewModel(string.Empty, error.Description));
                    }
                }
            }
            else
            {
                errors.Add(new ErrorViewModel(nameof(signUpViewModel.FirstName), "this First Name is already used in another Account"));
                errors.Add(new ErrorViewModel(nameof(signUpViewModel.LastName), "this Last Name is already used in another Account"));
            }

            return errors;
        }
        public async Task<List<ErrorViewModel>> SignIn(SignInViewModel signInViewModel)
        {
            var errors = new List<ErrorViewModel>();

            var user = await _userManager.FindByEmailAsync(signInViewModel.Email);

            if (user is { })
            {
                var flag = await _userManager.CheckPasswordAsync(user, signInViewModel.Password);
                if (flag)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, signInViewModel.Password, signInViewModel.RememberMe, false);
                    if (result.IsNotAllowed)
                    {
                        errors.Add(new ErrorViewModel(string.Empty, "Your account is not confirmed yet"));
                    }

                    if (result.IsLockedOut)
                    {
                        errors.Add(new ErrorViewModel(string.Empty, "Your account is locked!!"));
                    }

                    if (result.Succeeded)
                    {
                        
                    }

                }

            }

            return errors;
        }
        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
