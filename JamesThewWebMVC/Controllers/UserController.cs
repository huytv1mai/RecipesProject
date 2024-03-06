using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Competition()
        {
            return View();
        }
        public IActionResult Post()
        {
            return View();
        }
        public IActionResult Saved()
        {
            return View();
        }
    }
}
