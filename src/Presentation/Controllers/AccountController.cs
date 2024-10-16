using DataAccess.Abstacts;
using DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Presentation.ViewModels;
using System.Linq.Expressions;

namespace Presentation.Controllers
{
    public class AccountController : Controller
    {
        #region Services
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole<uint>> _roleManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole<uint>> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        #endregion

        #region Sign Up
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel signUpViewModel)
        {
            if (ModelState.IsValid)
            {
                return BadRequest();
            }
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
                    return RedirectToAction(nameof(SignIn));
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            else
            {
                ModelState.AddModelError(nameof(signUpViewModel.FirstName), "this First Name is already used in another Account");
                ModelState.AddModelError(nameof(signUpViewModel.LastName), "this Last Name is already used in another Account");
            }
            return View(signUpViewModel);
        }
        #endregion

        #region Sign In
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel signInViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var user = await _userManager.FindByEmailAsync(signInViewModel.Email);

            if (user is { })
            {
                var flag = await _userManager.CheckPasswordAsync(user, signInViewModel.Password);
                if (flag)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, signInViewModel.Password, signInViewModel.RememberMe, false);
                    if (result.IsNotAllowed)
                    {
                        ModelState.AddModelError(string.Empty, "Your account is not confirmed yet");
                    }

                    if (result.IsLockedOut)
                    {
                        ModelState.AddModelError(string.Empty, "Your account is locked!!");
                    }

                    if (result.Succeeded)
                    {
                        return RedirectToAction(nameof(HomeController.Index), "Home");
                    }

                }

            }
            ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");

            return View(signInViewModel);
        }
        #endregion

        #region Sign Out
        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(SignIn));
        }
        #endregion
    }
}
