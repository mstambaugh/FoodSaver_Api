using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FoodSaverApi.Models
{
    public class FoodSaverApiContext : DbContext
    {
        public FoodSaverApiContext(DbContextOptions<FoodSaverApiContext> options)
            : base(options)
        {

        }

        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<IngredientRecipe> IngredientRecipes { get; set; }
        public FoodSaverApiContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ingredient>()
                .HasData(
                    new Ingredient { IngredientId = 1, IngredientName = "1 lb wheat spaghetti", IngredientPrice = 1.20m, IngredientSubstitution = "1 lb wheat pasta any shape" },
                    new Ingredient { IngredientId = 2, IngredientName = "large can tomatoes", IngredientPrice = 1.10m, IngredientSubstitution = "large can tomato sauce" },
                    new Ingredient { IngredientId = 3, IngredientName = "1/2 medium onion", IngredientPrice =  .70m, IngredientSubstitution = "onion powder"},
                    new Ingredient { IngredientId = 4, IngredientName = "garlic powder", IngredientPrice = 1.50m, IngredientSubstitution = "italian seasoning" }
                );
            builder.Entity<Recipe>()
                .HasData(
                    new Recipe { RecipeId = 1, RecipeName = "Spaghetti and Marinara", Directions = "do this, this, and this. How to store leftovers.", NutritionInfo = "fiber, vitamins, minerals, hella flavor ", RecipeTips = "save the leftover half of your onion for other crap. How to store info. What you can add if you have it."}
                    // new Recipe { RecipeId = 1, RecipeName = " ", Directions = " ", NutritionInfo = " ", RecipeTips = " " },
                    // new Recipe { RecipeId = 1, RecipeName = " ", Directions = " ", NutritionInfo = " ", RecipeTips = " " },
                    // new Recipe { RecipeId = 1, RecipeName = " ", Directions = " ", NutritionInfo = " ", RecipeTips = " " }
                );
            builder.Entity<IngredientRecipe>()
                .HasData(
                    new IngredientRecipe { IngredientRecipeId = 1, RecipeId = 1, IngredientId = 1 },
                    new IngredientRecipe { IngredientRecipeId = 2, RecipeId = 1, IngredientId = 2 },
                    new IngredientRecipe { IngredientRecipeId = 3, RecipeId = 1, IngredientId = 3 },
                    new IngredientRecipe { IngredientRecipeId = 4, RecipeId = 1, IngredientId = 4 }
                );
                    
         }
    }
}



