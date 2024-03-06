using JamesThewWebMVC.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using DataAccess.Models;
using DataAccess.Helpers;
using Microsoft.EntityFrameworkCore;
using System;

namespace JamesThewWebMVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly JamesThewDbContext _db;
        public LoginController(JamesThewDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginModel model)
        {
            // pass 123abc#!
            if (ModelState.IsValid)
            {
                var hashedPassword = md5.ComputeMD5Hash(model.Password);
                var user = await _db.Users.FirstOrDefaultAsync(x => x.UserName.Contains(model.UserName) && x.Password.Contains(hashedPassword));
                if (user != null)
                {
                    var role = await _db.Roles.FirstOrDefaultAsync(x => x.RoleId == user.RoleId);
                    var userDetail = await _db.UserDetails.FirstOrDefaultAsync(x => x.UserId == user.UserId);
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, userDetail.Email),
                        new Claim(ClaimTypes.Name, userDetail.FristName),
                        new Claim(ClaimTypes.GivenName, userDetail.LastName),
                        new Claim(ClaimTypes.Role, role.RoleName)
                    };

                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public IActionResult Register(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var newUser = new User { UserName = model.UserName, Password = model.Password, RoleId = 2, SubscriptionTypeId = 3 };
                    var newUserEmail = new UserDetail { Email = model.Email };
                    _db.Users.Add(newUser);
                    _db.UserDetails.Add(newUserEmail);
                    _db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return RedirectToAction("Index", "Login");
        }
    }
}
