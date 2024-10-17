using Application.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Shared.DTO;
using System.Security.Claims;

namespace Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        protected readonly UserManager<Staff> _userManager;
        private readonly SignInManager<Staff> _signInManager;
        protected readonly RoleManager<IdentityRole<uint>> _roleManager;

        public AuthenticationService(UserManager<Staff> userManager, 
            SignInManager<Staff> signInManager, 
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
                user = new Staff
                {
                    firstName = signUpViewModel.FirstName,
                    lastName = signUpViewModel.LastName,
                    UserName = signUpViewModel.FirstName + "" + signUpViewModel.LastName,
                    Email = signUpViewModel.Email,
                    PhoneNumber = signUpViewModel.PhoneNumber,
                    Address = signUpViewModel.Address,
                    gender = signUpViewModel.Gender,
                };
                switch (signUpViewModel.Role)
                {
                    case 1:
                        role = "ADMIN";
                        break;
                    case 2:
                        role = "DOCTOR";
                        break;
                    case 3:
                        role = "Nurse";
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
        public async Task<(List<ErrorViewModel>, Staff?)> SignIn(StaffSignInViewModel signInViewModel)
        {
            var errors = new List<ErrorViewModel>();

            var user = await _userManager.FindByEmailAsync(signInViewModel.Email);

            if (user == null)
            {
                errors.Add(new ErrorViewModel("Email", "Invalid Email Address"));
                return (errors, null);
            }

            var flag = await _userManager.CheckPasswordAsync(user, signInViewModel.Password);
            if (!flag)
            {
                errors.Add(new ErrorViewModel("Password", "Invalid Password"));
                return (errors, null);
            }
            await _userManager.AddClaimAsync(user, new Claim(ClaimTypes.Email, user.Email));
            var result = await _signInManager.PasswordSignInAsync(user, signInViewModel.Password, signInViewModel.RememberMe, false);
            
            if (result.IsNotAllowed)
            {
                errors.Add(new ErrorViewModel(string.Empty, "Your account is not confirmed yet"));
            }

            if (result.IsLockedOut)
            {
                errors.Add(new ErrorViewModel(string.Empty, "Your account is locked!!"));
            }

            return (errors, user);
        }
        public async Task SignOut()
        {
            await _signInManager.SignOutAsync();
        }
        public async Task<string> GetUserRole(Staff staff)
        {
            var roles = await _userManager.GetRolesAsync(staff);

            if(roles.Count() == 0)
            {
                return null;
            }

            return roles[0];
        }
    }
}
