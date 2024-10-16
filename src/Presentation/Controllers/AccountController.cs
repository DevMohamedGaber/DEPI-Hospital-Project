using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Shared.DTO;

namespace Presentation.Controllers
{
    public class AccountController : Controller
    {
        private IAuthenticationService _service;
        public AccountController(IAuthenticationService service)
        {
            this._service = service;
        }

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

            var errors = await _service.SignUp(signUpViewModel);
            if (errors == null || errors.Count() == 0)
            {
                InjectErrors(errors);
                return View(signUpViewModel);
            }

            return RedirectToAction(nameof(SignIn));
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
                Console.WriteLine(signInViewModel.Email);
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
                return View();
            }
            
            var errors = await _service.SignIn(signInViewModel);

            if(errors == null || errors.Count() == 0)
            {
                InjectErrors(errors);
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
                return View(signInViewModel);
            }

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
        #endregion

        #region Sign Out
        public async Task<IActionResult> SignOut()
        {
            await _service.SignOut();
            return RedirectToAction(nameof(SignIn));
        }
        #endregion

        void InjectErrors(List<ErrorViewModel> errors)
        {
            foreach (var error in errors)
            {
                ModelState.AddModelError(error.fieldName, error.message);
            }
        }
    }
}
