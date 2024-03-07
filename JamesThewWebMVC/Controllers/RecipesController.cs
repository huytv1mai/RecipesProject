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
            var listRecipes = _db.Recipes.Include(x => x.Images);
            return View(listRecipes);
        }
        public IActionResult Detail(int id)
        {
            //var recipe = _db.Recipes.Include(x => x.Images).FirstOrDefault(r => r.RecipeId == id);
            //if (recipe == null)
            //{
            //    return NotFound();
            //}
            //ví dụ để hiển thị
            var recipe = new Recipe
            {
                RecipeId = 1,
                Title = "Sample Recipe",
                Details = "Lorem ipsum dolor sit amet, consectetur adipiscing elit...",
                Ingredients = "Ingredient 1, Ingredient 2, Ingredient 3",
                DatePosted = DateTime.Now
            };
            return View(recipe);
        }
    }
}
