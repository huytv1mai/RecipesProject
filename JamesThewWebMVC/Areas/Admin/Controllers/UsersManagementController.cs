using Microsoft.AspNetCore.Mvc;
using JamesThewWebMVC.Areas.Admin.Models;

namespace JamesThewWebMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    [Route("Admin/usersmanagement")]
    public class UsersManagementController : Controller
    {
        [Route("")]
        [Route("index")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        [Route("create")]
        public IActionResult Create()
        {
            // Action để hiển thị form tạo mới người dùng
            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(UserViewModel model)
        {

            if (ModelState.IsValid)
            {

                return RedirectToAction("Index");
            }

            return View(model);
        }

        //[HttpGet]
        //[Route("edit/{id}")]
        //public IActionResult Edit(int id)
        //{
       
        //    var user = _userService.GetUserById(id);
        //    if (user == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(user);
        //}

        //[HttpPost]
        //[Route("edit/{id}")]
        //public IActionResult Edit(int id, UserViewModel model)
        //{
        //    // Action để xử lý chỉnh sửa thông tin người dùng
        //    if (ModelState.IsValid)
        //    {
        //        // Xử lý cập nhật thông tin người dùng vào cơ sở dữ liệu
        //        return RedirectToAction("Index");
        //    }
        //    // Trả về view với model nếu có lỗi xảy ra
        //    return View(model);
        //}

        //[HttpPost]
        //[Route("delete/{id}")]
        //public IActionResult Delete(int id)
        //{
        //    // Action để xử lý xóa người dùng
        //    // Xử lý xóa người dùng từ cơ sở dữ liệu dựa trên id
        //    _userService.DeleteUser(id);
        //    return RedirectToAction("Index");
        //}
    }
}
