namespace BookStore_project_RazorPage.Services.Role;

public class RoleService : IRoleService
{
    private HttpClient _httpClient;

    public RoleService(HttpClient httpClient) => _httpClient = httpClient;
}

