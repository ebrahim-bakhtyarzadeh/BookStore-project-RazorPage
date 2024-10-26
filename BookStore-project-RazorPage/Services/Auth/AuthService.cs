using BookStore_project_RazorPage.Models;
using BookStore_project_RazorPage.Models.Auth;
using System.Net;

namespace BookStore_project_RazorPage.Services.Auth;

public class AuthService: IAuthService
{
    private HttpClient _httpClient;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<ApiResult<LoginResponse>?> Login(LoginCommand commnad)
    {
        var result =await _httpClient.PostAsJsonAsync("auth/login", commnad);
        if (result.StatusCode != HttpStatusCode.OK)
            return new ApiResult<LoginResponse>() {IsSuccess = false };
        return await result.Content.ReadFromJsonAsync<ApiResult<LoginResponse>>();
    }


    public Task<ApiResult> Logout() => throw new NotImplementedException();
    public Task<ApiResult<LoginResponse>> RefreshToken(string refreshToken) => throw new NotImplementedException();
    public Task<ApiResult> Register(RegisterCommand command) => throw new NotImplementedException();
}