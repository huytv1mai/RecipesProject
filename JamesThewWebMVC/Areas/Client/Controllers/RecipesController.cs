using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Client.Controllers
{
	[Area("Client")]
	[Route("Client")]
	[Route("Client/recipes")]
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
