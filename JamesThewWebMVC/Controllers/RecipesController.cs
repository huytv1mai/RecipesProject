using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JamesThewWebMVC.Controllers
{
    public class RecipesController : Controller
    {
        private readonly JamesThewDbContext _db;
        public RecipesController(JamesThewDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listRecipes = _db.Recipes.Include(x=>x.Images);
            return View(listRecipes);
        }
    }
}
