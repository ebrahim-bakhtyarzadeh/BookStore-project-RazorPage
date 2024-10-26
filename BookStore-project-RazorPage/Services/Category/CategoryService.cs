namespace BookStore_project_RazorPage.Services.ICategoryService;

public class CategoryService: ICategoryService
{
    private HttpClient _httpClient;

    public CategoryService(HttpClient httpClient) => _httpClient = httpClient;
}
