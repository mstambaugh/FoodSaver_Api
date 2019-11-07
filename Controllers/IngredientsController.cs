using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FoodSaverApi.Models;
using Microsoft.EntityFrameworkCore;


namespace FoodSaverApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredientsController : ControllerBase
    {
        private FoodSaverApiContext _db;

        public IngredientsController(FoodSaverApiContext db)
        {
            _db = db;
        }
        // get api/ingredients/?ingredientPrice
        [HttpGet]
        public ActionResult<IEnumerable<Ingredient>> Get(string ingredientName, int ingredientQuantity, decimal ingredientPrice, string ingredientSubstitution)
        {
            var query = _db.Ingredients.AsQueryable();

            if (ingredientName != null)
            {
                query = query.Where(entry => entry.IngredientName == ingredientName);
            }
            if (ingredientQuantity > 0)
            {
                query = query.Where(entry => entry.IngredientQuantity == ingredientQuantity);
            }
            if (ingredientPrice > 0)
            {
                query = query.Where(entry => entry.IngredientPrice == ingredientPrice);
            }

            if (ingredientSubstitution != null)
            {
                query = query.Where(entry => entry.IngredientSubstitution == ingredientSubstitution);
            }
            return query.ToList();
        }

        // Get api/ingredients/ingredientId
        [HttpGet("{id}")]
        public ActionResult<Ingredient> Get(int id)
        {
            return _db.Ingredients.FirstOrDefault(entry => entry.IngredientId == id);
        }
    }
}