using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Client.Controllers
{
	[Area("Client")]
	[Route("Client")]
	[Route("Client/home")]
	public class HomeController : Controller
	{
		[Route("")]
		[Route("index")]
		public IActionResult Index()	
		{
			return View();
		}
    }
}
