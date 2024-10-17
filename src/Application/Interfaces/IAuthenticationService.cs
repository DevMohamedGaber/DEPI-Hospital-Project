using DataAccess.Entities;
using Shared.DTO;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {
        Task<List<ErrorViewModel>> SignUp(SignUpViewModel signUpViewModel);
        Task<(List<ErrorViewModel>, Staff?)> SignIn(StaffSignInViewModel signInViewModel);
        Task SignOut();
        Task<string> GetUserRole(Staff staff);
    }
}
