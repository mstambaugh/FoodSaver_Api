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

        // GET api/ingredients
        [HttpGet]
        public ActionResult<IEnumerable<Ingredient>> Get()
        {
            return _db.Ingredients.ToList();
        }

        // POST api/ingredients
        [HttpPost]
        public void Post([FromBody] Ingredient ingredient)
        {
            _db.Ingredients.Add(ingredient);
            _db.SaveChanges();
        }
        [HttpGet("{id}")]
        public ActionResult<Ingredient> Get(int id)
        {
            return _db.Ingredients.FirstOrDefault(entry => entry.IngredientId == id);
        }
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Ingredient ingredient)
        {
            ingredient.IngredientId = id;
            _db.Entry(ingredient).State = EntityState.Modified;
            _db.SaveChanges();
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ingredientToDelete = _db.Ingredients.FirstOrDefault(entry => entry.IngredientId == id);
            _db.Ingredients.Remove(ingredientToDelete);
            _db.SaveChanges();
        }
    }
}