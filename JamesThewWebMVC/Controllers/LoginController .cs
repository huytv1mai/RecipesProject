using Azure.Core;
using DataAccess.Models;
using JamesThewWebMVC.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using JamesThewWebMVC.Models;
using System.Diagnostics;
using System.Security.Claims;

namespace JamesThewWebMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid) // Check if the model is valid
            {
                if (model.UserName == "client" && model.Password == "client")
                {
                    TempData["Info"] = "Client";
                    return RedirectToAction("Index", "Home", new { area = "Client" });
                }
                else if (model.UserName == "admin" && model.Password == "admin")
                {
                    TempData["Info"] = "Client";
                    return RedirectToAction("Index", "HomeAdmin", new { area = "Admin" });
                }
                else
                {
                    ModelState.AddModelError("", "Invalid username or password."); // Add model error if credentials are incorrect
                }
            }
            return View(model);
        }
        //IUsersRepository userRepository = null;
        //public LoginController()
        //{
        //    userRepository = new UsersRepository();
        //}
        //public IActionResult Index(string ReturnUrl = null)
        //{
        //    TempData["ReturnUrl"] = ReturnUrl;
        //    return View();
        //}

        //[HttpPost]
        //public IActionResult Index(LoginModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var username = model.UserName;
        //        var password = model.Password;
        //        User user = userRepository.CheckLogin(username, Common.Common.EncryptMD5(password));
        //        if (!string.IsNullOrEmpty(username) && string.IsNullOrEmpty(password))
        //        {
        //            return RedirectToAction("Index");
        //        }
        //        if (user != null)
        //        {
        //            //A claim is a statement about a subject by an issuer and    
        //            //represent attributes of the subject that are useful in the context of authentication and authorization operations.
        //            var claims = new List<Claim>() {
        //                new Claim(ClaimTypes.Name, username),
        //                 new Claim("FullName", user.UserName),
        //                new Claim(ClaimTypes.Role, "Admin"),
        //            };
        //            //Initialize a new instance of the ClaimsIdentity with the claims and authentication scheme    
        //            var identity = new ClaimsIdentity(claims, "Admin");
        //            //Initialize a new instance of the ClaimsPrincipal with ClaimsIdentity    
        //            var principal = new ClaimsPrincipal(identity);
        //            //SignInAsync is a Extension method for Sign in a principal for the specified scheme.    
        //            HttpContext.SignInAsync("Admin", principal, new AuthenticationProperties()
        //            {
        //                IsPersistent = true
        //            });
        //            SetAlert("Đăng nhập thành công!", "success");
        //            var routeValues = new RouteValueDictionary
        //        {
        //            {"area","Admin" },
        //            {"returnURL",Request.Query["ReturnUrl"] },
        //            {"claimValue","true" }
        //        };

        //            TempData["Info"] = "Admin";
        //            if (TempData["ReturnUrl"] != null)
        //            {
        //                return Redirect(TempData["ReturnUrl"].ToString());
        //            }
        //            return RedirectToAction("Index", "Home", routeValues);
        //        }
        //        else
        //        {
        //            SetAlert("Tên đăng nhập hoặc mật khẩu không đúng!", "error");
        //            /*                    TempData["Fail"] = "Tên đăng nhập hoặc mật khẩu không đúng!";*/
        //        }
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("Error",
        //                         "Please input field full!");
        //    }
        //    return View(model);
        //}
    }
}
