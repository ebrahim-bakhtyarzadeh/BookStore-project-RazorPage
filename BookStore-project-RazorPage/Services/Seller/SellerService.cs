namespace BookStore_project_RazorPage.Services.Seller;

public class SellerService : ISellerService
{
    private HttpClient _httpClient;

    public SellerService(HttpClient httpClient) => _httpClient = httpClient;
}
