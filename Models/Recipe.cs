using System.Collections.Generic;

namespace FoodSaverApi.Models
{
    public class Recipe 
    {
        public Recipe()
        {
            this.Ingredients = new HashSet<IngredientRecipe>();
        }
        public int RecipeId { get; set; }
        public string RecipeName { get; set; }
        public string RecipePhoto { get; set; }
        public int BaseServings { get; set; }
        public decimal CostPerServing { get; set; }
        public string PrepTime { get; set; }
        public string Directions { get; set; }
        public string NutritionInfo { get; set; }
        public string RecipeTips { get; set; }
        public ICollection<IngredientRecipe> Ingredients { get; set; }
        
    }
}