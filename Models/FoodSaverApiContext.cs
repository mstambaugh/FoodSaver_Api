using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FoodSaverApi.Models
{
    public class FoodSaverApiContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<IngredientRecipe> IngredientRecipes { get; set; }
        public FoodSaverApiContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Ingredient>()
                .HasData(
                    new Ingredient { IngredientId = 1, IngredientQuantity = 2, IngredientName = "lb wheat spaghetti", IngredientPrice = 1.20m, IngredientSubstitution = "lb wheat pasta any shape" },
                    new Ingredient { IngredientId = 2, IngredientQuantity = 1, IngredientName = "28oz can diced tomatoes", IngredientPrice = 1.10m,IngredientSubstitution = "double tomato sauce quantity" },
                    new Ingredient { IngredientId = 3, IngredientQuantity = 1, IngredientName = "16oz can tomato sauce", IngredientPrice = .60m,IngredientSubstitution = "jar tomato-basil/marinara pasta sauce" },
                    new Ingredient { IngredientId = 4, IngredientQuantity = 1, IngredientName = "large onion", IngredientPrice =  .70m, IngredientSubstitution = "onion powder, diced vegetable"},
                    new Ingredient { IngredientId = 5, IngredientQuantity = 4, IngredientName = "cloves garlic", IngredientPrice = .50m, IngredientSubstitution = "garlic powder, italian seasoning" },
                    new Ingredient { IngredientId = 6, IngredientQuantity = 1, IngredientName = "lb ground beef chuck 80/20", IngredientPrice = 3.00m, IngredientSubstitution = "lb fresh or frozen ground beef/turkey/lean pork." },
                    new Ingredient { IngredientId = 7, IngredientQuantity = 1, IngredientName = "7-9oz box white cheddar macaroni and cheese", IngredientPrice = .75m, IngredientSubstitution = "any flavor boxed macaroni and cheese" },
                    new Ingredient { IngredientId = 8, IngredientQuantity = 1, IngredientName = " 12oz frozen broccolli florets", IngredientPrice = 1.00m, IngredientSubstitution = "any flavor boxed macaroni and cheese" },
                    new Ingredient { IngredientId = 9, IngredientQuantity = 1, IngredientName = "7-9oz box white cheddar macaroni and cheese", IngredientPrice = .75m, IngredientSubstitution = "any flavor boxed macaroni and cheese" }
                );
            builder.Entity<Recipe>()
                .HasData(
                    // this recipe is 8 servings baseline
                    new Recipe { RecipeId = 1, RecipeName = "Spaghetti and Beef Marinara", PricePerServing = 1.00m, Directions = "do this, this, and this.", NutritionInfo = "fiber, vitamins, minerals, hella flavor ", RecipeTips = "How to turn this into leftovers for lunch. save the leftover half of your onion for other crap. How to store info. What you can add if you have it."},
                    // this recipe is 3 servings baseline
                    new Recipe { RecipeId = 2, RecipeName = "Tuna Mac and Cheese", PricePerServing = 2.25m, Directions = "1) Steam brocolli in microwave or in a covered pot with steamer on the stovetop. 2) Open and strain canned tuna 2) Boil macaroni according to package instructions, strain pasta, and combine with steamed brocolli, packaged cheese, extra cheese, milk, tuna, and salt and pepper to taste. Return to microwave or pot on stovetop and heat on low until cheese is melted.", NutritionInfo = " ", RecipeTips = " " }
                    // new Recipe { RecipeId = 1, RecipeName = " ", Directions = " ", NutritionInfo = " ", RecipeTips = " " },
                    // new Recipe { RecipeId = 1, RecipeName = " ", Directions = " ", NutritionInfo = " ", RecipeTips = " " }
                );
            builder.Entity<IngredientRecipe>()
                .HasData(
                    new IngredientRecipe { IngredientRecipeId = 1, RecipeId = 1, IngredientId = 1 },
                    new IngredientRecipe { IngredientRecipeId = 2, RecipeId = 1, IngredientId = 2 },
                    new IngredientRecipe { IngredientRecipeId = 3, RecipeId = 1, IngredientId = 3 },
                    new IngredientRecipe { IngredientRecipeId = 4, RecipeId = 1, IngredientId = 4 },
                    new IngredientRecipe { IngredientRecipeId = 5, RecipeId = 1, IngredientId = 5 },
                    new IngredientRecipe { IngredientRecipeId = 6, RecipeId = 1, IngredientId = 6 }
                );
                    
         }
    }
}



