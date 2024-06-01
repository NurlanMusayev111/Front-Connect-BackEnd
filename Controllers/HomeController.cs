using Microsoft.AspNetCore.Mvc;

namespace FrontEndProject_Connect_BackEnd.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
