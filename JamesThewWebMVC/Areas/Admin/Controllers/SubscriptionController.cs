using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    [Route("Admin/subscription")]
    public class SubscriptionController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateSubscriptionSettings(decimal monthlyPrice, decimal yearlyPrice)
        {
            return RedirectToAction("SubscriptionManagement");
        }
    }
}
