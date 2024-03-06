using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
