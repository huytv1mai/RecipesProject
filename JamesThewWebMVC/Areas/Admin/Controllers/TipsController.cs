using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    [Route("Admin/tips")]
    public class TipsController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
