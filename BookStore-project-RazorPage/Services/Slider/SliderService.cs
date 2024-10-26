namespace BookStore_project_RazorPage.Services.Slider;

public class SliderService : ISliderService
{
    private HttpClient _httpClient;

    public SliderService(HttpClient httpClient) => _httpClient = httpClient;
}
