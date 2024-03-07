using DataAccess.Models;
using JamesThewWebMVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System.Security.Claims;

namespace JamesThewWebMVC.Controllers
{
    public class UserController : Controller
    {
        private JamesThewDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public UserController(JamesThewDbContext db , IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                var yourProfile = _db.UserDetails.Where(x => x.Email.Contains(email));
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

        [HttpGet]
        public IActionResult Post()
        {
            return View();
        }
        [HttpPost]
        [Authorize]
        public IActionResult Post(RecipeModel model)
        {
            if (ModelState.IsValid)
            {
                // Lưu thông tin recipe vào cơ sở dữ liệu
                var email = User.FindFirst(ClaimTypes.Email)?.Value;
                var yourProfile = _db.UserDetails.FirstOrDefault(x => x.Email == email);

                if (yourProfile != null)
                {
                    var recipe = new Recipe
                    {
                        Title = model.Title,
                        Details = model.Details,
                        Ingredients = model.Ingredients,
                        DatePosted = DateTime.Now,
                        Status = true,
                        Type = model.Type,
                        ContestId = model.ContestId
                    };

                    _db.Recipes.Add(recipe);
                    _db.SaveChanges();
                    return RedirectToAction("Post");
                }
                else
                {
                    return NotFound();
                }
            }
            return View(model);
        }
        public IActionResult Saved()
        {
            return View();
        }
    }
}
