namespace BookStore_project_RazorPage.Services.User;

public class UserService: IUserService
{
    private HttpClient _httpClient;

    public UserService(HttpClient httpClient) => _httpClient = httpClient;
}
