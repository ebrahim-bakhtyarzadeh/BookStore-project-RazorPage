namespace BookStore_project_RazorPage.Services.Banner;

public class BannerService :IBannerService
{
    private HttpClient _httpClient;

    public BannerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
}
