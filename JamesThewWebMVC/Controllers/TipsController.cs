using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Controllers
{
    public class TipsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
