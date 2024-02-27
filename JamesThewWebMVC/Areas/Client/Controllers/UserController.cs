using JamesThewWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace JamesThewWebMVC.Areas.Client.Controllers
{
	[Area("Client")]
	[Route("Client/user")]
	public class UserController : Controller
	{
		[Route("")]
		[Route("index")]
		public IActionResult Index()	
		{
			return View();
		}
        [Route("saved")]
        public IActionResult Saved()
        {
            return View();
        }
        [Route("post")]
        public IActionResult Post()
        {
            return View();
        }
        [HttpPost]
        [Route("submit")]
        public IActionResult Submit(PostModel model)
        {
            if (ModelState.IsValid)
            {
                string content = model.Content; // Lấy nội dung từ model

                // Xử lý dữ liệu ở đây, ví dụ: lưu vào cơ sở dữ liệu

                return RedirectToAction("Index"); // Chuyển hướng sau khi xử lý xong
            }
            else
            {
                // Nếu dữ liệu không hợp lệ, quay trở lại view Post để hiển thị lỗi
                return View("Post", model);
            }
        }

        [Route("Competition")]
        public IActionResult Competition()
        {
            return View();
        }
    }
}
