using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_BookStore.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin")]
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("details/{id}")]
        public ActionResult Details(int id)
        {
            return View(id);
        }
    }
}
