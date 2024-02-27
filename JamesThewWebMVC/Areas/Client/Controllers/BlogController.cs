using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Client.Controllers
{
	[Area("Client")]
	[Route("Client")]
	[Route("Client/blog")]
	public class BlogController : Controller
	{
		[Route("")]
		[Route("index")]
		public IActionResult Index()	
		{
			return View();
		}
    }
}
