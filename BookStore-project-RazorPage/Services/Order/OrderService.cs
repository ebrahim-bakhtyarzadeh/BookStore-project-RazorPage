namespace BookStore_project_RazorPage.Services.Product;

public class OrderService : IOrderService
{
    private HttpClient _httpClient;

    public OrderService(HttpClient httpClient) => _httpClient = httpClient;
}