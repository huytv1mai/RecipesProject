using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
