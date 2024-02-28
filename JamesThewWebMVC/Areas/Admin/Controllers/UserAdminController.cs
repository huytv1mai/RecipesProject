using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    [Route("Admin/useradmin")]
    public class UserAdminController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
