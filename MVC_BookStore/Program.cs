using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MVC_BookStore.Data;
using MVC_BookStore.Helpers;
using MVC_BookStore.Models;
using MVC_BookStore.Repository;
using MVC_BookStore.Service;
using MVC_BookStore.Data;
using MVC_BookStore.Helpers;
using MVC_BookStore.Models;
using MVC_BookStore.Repository;
using MVC_BookStore.Service;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(
    options => options.UseSqlServer(builder.Configuration["ConnectionStrings:BookStoreDatabase"]));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequiredLength = 5;
    options.Password.RequiredUniqueChars = 1;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;

    options.SignIn.RequireConfirmedEmail = true;

    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(10);
    options.Lockout.MaxFailedAccessAttempts = 3;
});

builder.Services.Configure<DataProtectionTokenProviderOptions>(options =>
{
    options.TokenLifespan = TimeSpan.FromHours(5);
});

builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = builder.Configuration.GetValue<string>("Application:LoginPath");
});

builder.Services.AddControllersWithViews();

#if DEBUG
builder.Services
    .AddRazorPages()
    .AddRazorRuntimeCompilation();
//    .AddViewOptions(option =>
//{
//    option.HtmlHelperOptions.ClientValidationEnabled = false;
//});
#endif

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IUserClaimsPrincipalFactory<ApplicationUser>, ApplicationUserClaimsPrincipalFactory>();


builder.Services.Configure<SMTPConfigModel>(builder.Configuration.GetSection("SMTPConfig"));

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapDefaultControllerRoute();

app.MapControllerRoute(
    name: "AdminArea",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.Run();
