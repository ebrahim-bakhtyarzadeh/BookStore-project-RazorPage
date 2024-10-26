using BookStore_project_RazorPage.Services.Auth;
using BookStore_project_RazorPage.Services.Banner;
using BookStore_project_RazorPage.Services.Comment;
using BookStore_project_RazorPage.Services.ICategoryService;
using BookStore_project_RazorPage.Services.Product;
using BookStore_project_RazorPage.Services.Role;
using BookStore_project_RazorPage.Services.Seller;
using BookStore_project_RazorPage.Services.Slider;
using BookStore_project_RazorPage.Services.User;
using BookStore_project_RazorPage.Services.UserAddress;

namespace BookStore_project_RazorPage.Infrastructure;

public static class RegisterServices
{
    public static IServiceCollection RegisterApiService (this IServiceCollection services)
    {
        const string BaseAddress = "https://localhost:7285";

        services.AddHttpClient<IAuthService, AuthService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<IBannerService, BannerService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<ICategoryService, CategoryService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<ICommentService, CommentService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<IOrderService, OrderService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<IRoleService, RoleService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<ISellerService, SellerService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<ISliderService, SliderService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<IUserService, UserService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        services.AddHttpClient<IUserAddressService, UserAddressService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });

        services.AddHttpClient<IAuthService, AuthService>(config =>
        {
            config.BaseAddress = new Uri(BaseAddress);
        });
        return services;
    }
}
