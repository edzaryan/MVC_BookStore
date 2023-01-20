using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MVC_BookStore.Models;
using MVC_BookStore.Service;

namespace MVC_BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;
        public readonly IEmailService _emailService;

        public HomeController(IUserService userService, IEmailService emailService)
        {
            _userService = userService;
            _emailService = emailService;
        }

        public async Task<ViewResult> Index()
        {
            //UserEmailOptions options = new UserEmailOptions
            //{
            //    ToEmails = new List<string>() { "melfox701@gmail.com" },
            //    PlaceHolders = new List<KeyValuePair<string, string>>()
            //    {
            //        new KeyValuePair<string, string>("{{UserName}}", "Nitish")
            //    }
            //};

            //await _emailService.SendTestEmail(options);

            //var userId = _userService.GetUserId();
            //var isLoggedIn = _userService.IsAuthenticated();

            return View();
        }

        public ViewResult AboutUs(string name)
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public ViewResult ContactUs()
        {
            return View();
        }
    }
}
