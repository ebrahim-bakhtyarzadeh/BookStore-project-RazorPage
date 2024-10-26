using BookStore_project_RazorPage.Infrastructure;
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

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.RegisterApiService();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
