namespace BookStore_project_RazorPage.Services.Auth;

public class AuthService: IAuthService
{
    private HttpClient _httpClient;

    public AuthService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}