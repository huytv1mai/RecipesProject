using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Client.Controllers
{
	[Area("Client")]
	[Route("Client")]
	[Route("Client/about")]
	public class AboutController : Controller
	{
		[Route("")]
		[Route("index")]
		public IActionResult Index()	
		{
			return View();
		}
    }
}
