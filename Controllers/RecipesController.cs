using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FoodSaverApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodSaverApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        private FoodSaverApiContext _db;

        public RecipesController(FoodSaverApiContext db)
        {
            _db = db;
        }
       
        // Get recipes/?recipeName
        [HttpGet]
        public ActionResult<IEnumerable<Recipe>> Get(string recipeName, string directions, string nutritionInfo, string recipeTips)
        {
            var query = _db.Recipes.AsQueryable();

            if (recipeName != null)
            {
                query = query.Where(entry => entry.RecipeName == recipeName);
            }

            if (directions != null)
            {
                query = query.Where(entry => entry.Directions == directions);
            }

            if (nutritionInfo != null)
            {
                query = query.Where(entry => entry.NutritionInfo == nutritionInfo);
            }
            if (recipeTips != null)
            {
                query = query.Where(entry => entry.RecipeTips == recipeTips);
            }
            return query.ToList();
        }
        // get api/recipes/recipeId
        [HttpGet("{id}")]
        public ActionResult<Recipe> Get(int id)
        {
            return _db.Recipes.FirstOrDefault(entry => entry.RecipeId == id);
        }
        
    }
}