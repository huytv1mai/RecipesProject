using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    [Route("Admin/recipes")]
    public class RecipesController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
