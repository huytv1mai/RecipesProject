using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace JamesThewWebMVC.Controllers
{
    public class UserController : Controller
    {
        private JamesThewDbContext _db;
        public UserController(JamesThewDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                var yourProfile = _db.UserDetails.Where(x=>x.Email.Contains(email));
                ViewBag.Email = email;
                ViewBag.FristName = yourProfile.FirstOrDefault().FristName;
                ViewBag.LastName = yourProfile.FirstOrDefault().LastName;
                ViewBag.BirthOfDate = yourProfile.FirstOrDefault().BirthOfDate;
                ViewBag.Address = yourProfile.FirstOrDefault().Address;
                ViewBag.SubscriptionExpiry = Convert.ToDateTime(_db.Users.FirstOrDefault(x => x.UserId == yourProfile.FirstOrDefault().UserId).SubscriptionExpiry).ToShortDateString();
                return View();
            }
            else
            {
                return View();
            }
        }
        public IActionResult Competition()
        {
            return View();
        }
        public IActionResult Post()
        {
            return View();
        }
        public IActionResult Saved()
        {
            return View();
        }
    }
}
