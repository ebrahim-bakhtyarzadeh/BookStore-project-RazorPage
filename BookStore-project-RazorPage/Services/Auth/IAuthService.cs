using BookStore_project_RazorPage.Models;
using BookStore_project_RazorPage.Models.Auth;

namespace BookStore_project_RazorPage.Services.Auth;

public interface IAuthService
{
    Task<ApiResult<LoginResponse>?> Login(LoginCommand commnad);
    Task<ApiResult> Register(RegisterCommand command);
    Task<ApiResult<LoginResponse>> RefreshToken(string refreshToken);
    Task<ApiResult> Logout(); 
}
