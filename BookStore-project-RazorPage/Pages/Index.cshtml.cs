using BookStore_project_RazorPage.Models.Auth;
using BookStore_project_RazorPage.Services.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore_project_RazorPage.Pages;
public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IAuthService _authService;
    public IndexModel(ILogger<IndexModel> logger, IAuthService authService)
    {
        _logger = logger;
        _authService = authService;
    }

    public async void OnGet()
    {
      var result =  await _authService.Login(new LoginCommand() { Password = "123456789", PhoneNumber = "09361044714" });
    }
}
