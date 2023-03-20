using BookStore.Repository;
using BookStore.Service;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IUserService _userService;

        public HomeController(IBookRepository bookRepository, IUserService userService)
        {
            _bookRepository = bookRepository;
            _userService = userService;
        }

        [Route("~/")]
        public async Task<ViewResult> Index()
        {
            return View();
        }

        [Route("about-us")]
        public ViewResult AboutUs()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [Route("contact-us")]
        public ViewResult ContactUs() 
        {
            return View();
        }
    }
}
