using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Controllers
{
    public class ContestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
