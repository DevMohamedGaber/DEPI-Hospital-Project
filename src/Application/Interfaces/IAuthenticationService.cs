using Shared.DTO;

namespace Application.Interfaces
{
    public interface IAuthenticationService
    {
        Task<List<ErrorViewModel>> SignUp(SignUpViewModel signUpViewModel);
        Task<List<ErrorViewModel>> SignIn(SignInViewModel signInViewModel);
        Task SignOut();
    }
}
