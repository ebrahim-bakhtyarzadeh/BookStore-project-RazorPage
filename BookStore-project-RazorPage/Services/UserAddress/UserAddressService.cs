namespace BookStore_project_RazorPage.Services.UserAddress;

public class UserAddressService : IUserAddressService
{
    private HttpClient _httpClient;

    public UserAddressService(HttpClient httpClient) => _httpClient = httpClient;
}
