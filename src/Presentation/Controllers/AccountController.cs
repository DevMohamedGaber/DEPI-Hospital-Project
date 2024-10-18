using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;
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
        [Authorize(Roles = "Admin")]
        public IActionResult SignUp()
        {
            ViewBag.Roles = _service.GetAllRoles();
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> SignUp(SignUpViewModel signUpViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var errors = await _service.SignUp(signUpViewModel);
            if (errors != null && errors.Count() > 0)
            {
                InjectErrors(errors);
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
        public async Task<IActionResult> SignIn(StaffSignInViewModel signInViewModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
                return View(signInViewModel);
            }
            
            var result = await _service.SignIn(signInViewModel);
            if(result.Item1.Count() > 0)
            {
                InjectErrors(result.Item1);
                //ModelState.AddModelError(string.Empty, "Invalid Login Attempt.");
                return View(signInViewModel);
            }

            string role = await _service.GetUserRole(result.Item2);

            return RedirectToAction("Index", role);
        }
        #endregion

        #region Sign Out
        [Authorize]
        [HttpPost]
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
