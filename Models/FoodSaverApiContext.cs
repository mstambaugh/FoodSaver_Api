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
                    new Ingredient { IngredientId = 1, IngredientQuantity = 2, IngredientName = "lb wheat spaghetti", IngredientPrice = 1.20m, IngredientSubstitution = "lb wheat/whole grain pasta" },
                    new Ingredient { IngredientId = 2, IngredientQuantity = 1, IngredientName = "28oz can diced tomatoes", IngredientPrice = 1.10m,IngredientSubstitution = "double tomato sauce quantity" },
                    new Ingredient { IngredientId = 3, IngredientQuantity = 1, IngredientName = "16oz can tomato sauce", IngredientPrice = .60m,IngredientSubstitution = "jar tomato basil or marinara pasta sauce, 8oz tube of tomato paste diluted per instructions" },
                    new Ingredient { IngredientId = 4, IngredientQuantity = 1, IngredientName = "large onion", IngredientPrice =  .70m, IngredientSubstitution = "onion powder, diced vegetable"},
                    new Ingredient { IngredientId = 5, IngredientQuantity = 3, IngredientName = "cloves garlic", IngredientPrice = .50m, IngredientSubstitution = "garlic powder, garlic paste" },
                    new Ingredient { IngredientId = 6, IngredientQuantity = 1, IngredientName = "lb ground beef chuck 80/20", IngredientPrice = 3.00m, IngredientSubstitution = "lb fresh or frozen ground beef/turkey/lean pork." },
                    new Ingredient { IngredientId = 7, IngredientQuantity = 2, IngredientName = "7-9oz box white cheddar macaroni and cheese", IngredientPrice = 1.50m, IngredientSubstitution = "any flavor boxed macaroni and cheese" },
                    new Ingredient { IngredientId = 8, IngredientQuantity = 1, IngredientName = "12oz frozen broccoli", IngredientPrice = 1.00m, IngredientSubstitution = "12oz steam-in-bag frozen vegetable/vegetable mixes" },
                    new Ingredient { IngredientId = 9, IngredientQuantity = 1, IngredientName = "1/2 gallon 2% milk", IngredientPrice = 1.75m, IngredientSubstitution = "any variety of milk or non-dairy milk" },
                    new Ingredient { IngredientId = 10, IngredientQuantity = 1, IngredientName = "8oz white cheddar cheese block", IngredientPrice = 3.36m, IngredientSubstitution = "any variety of cheddar cheese- save by avoiding pre-shredded options" },
                    new Ingredient { IngredientId = 11, IngredientQuantity = 3, IngredientName = "3oz  package of flavored ramen noodle soup (Maruchan is the most widely available brand)", IngredientPrice = .60m, IngredientSubstitution = "thin whole wheat ramen noodles or instant ramen cup noodles" },
                    new Ingredient { IngredientId = 12, IngredientQuantity = 1, IngredientName = "8oz package pre-sliced white or brown mushrooms", IngredientPrice = 1.98m, IngredientSubstitution = "8 oz unsliced fresh mushrooms or small package dried shitake mushrooms" },
                    new Ingredient { IngredientId = 13, IngredientQuantity = 2, IngredientName = "half-dozen eggs", IngredientPrice = .50m, IngredientSubstitution = "dozen egg carton" },
                    new Ingredient { IngredientId = 14, IngredientQuantity = 1, IngredientName = "14oz package extra-firm tofu", IngredientPrice = 1.44m, IngredientSubstitution = "cooked and shredded chicken, pork, or beef" },
                    new Ingredient { IngredientId = 15, IngredientQuantity = 1, IngredientName = "12 oz bag of frozen mixed vegetables", IngredientPrice = .85m, IngredientSubstitution = " brocolli, califlower, carrots, and green beans" },
                    new Ingredient { IngredientId = 16, IngredientQuantity = 1, IngredientName = "18 oz container rolled oats", IngredientPrice = 1.76m, IngredientSubstitution = "18oz quick oats or bulk size rolled oats" },
                    new Ingredient { IngredientId = 17, IngredientQuantity = 2, IngredientName = "large banana", IngredientPrice = .42m, IngredientSubstitution = "18oz quick oats, bulk size rolled oats, " },
                    new Ingredient { IngredientId = 18, IngredientQuantity = 1, IngredientName = "18 oz tub creamy peanut butter", IngredientPrice = 2.00m, IngredientSubstitution = "crunchy peanut butter, reduced fat peanut butter" },
                    new Ingredient { IngredientId = 19, IngredientQuantity = 1, IngredientName = "16 oz bear of honey", IngredientPrice = 2.98m, IngredientSubstitution = " brown sugar, cinnamon sugar, maple syrup" },
                    new Ingredient { IngredientId = 20, IngredientQuantity = 3, IngredientName = "15oz can pinto beans", IngredientPrice = 1.74m, IngredientSubstitution = "15oz canned red, black, kidney, or mixed beans" },
                    new Ingredient { IngredientId = 21, IngredientQuantity = 1, IngredientName = "4oz can diced green chiles", IngredientPrice = .76m, IngredientSubstitution = "4 oz can roasted green chiles" },
                    new Ingredient { IngredientId = 22, IngredientQuantity = 1, IngredientName = "fresh bell pepper", IngredientPrice = 1.00m, IngredientSubstitution = "red, orange, or yellow pepper, small bag frozen bell peppers" },
                    new Ingredient { IngredientId = 23, IngredientQuantity = 1, IngredientName = "14-15oz can diced tomatoes", IngredientPrice = .46m, IngredientSubstitution = "can chili ready tomatoes or whole peeled tomatoes (slice to prep)" },
                    new Ingredient { IngredientId = 24, IngredientQuantity = 1, IngredientName = "lb ground pork sausage", IngredientPrice = 2.88m, IngredientSubstitution = "12oz fresh or frozen sausage links or patties" },
                    new Ingredient { IngredientId = 25, IngredientQuantity = 1, IngredientName = "large idaho/russet potato", IngredientPrice = .52m, IngredientSubstitution = "2 large red or yellow potatoes" },
                    new Ingredient { IngredientId = 26, IngredientQuantity = 1, IngredientName = "bunch fresh spinach", IngredientPrice = 1.48m, IngredientSubstitution = "small bag frozen spinach, 8oz can spinach in water(drained)" },
                    new Ingredient { IngredientId = 27, IngredientQuantity = 1, IngredientName = "dozen large eggs", IngredientPrice = 1.29m, IngredientSubstitution = "none" }








// re ingredient price-->quantity relationship- prices listed meet the minimum cost for # of ingredients, but some recipes, if doubled, wouldn't require the price to change since there is an excess of quantity for that price (lowest available). We may have to think through that when we are calculating doubling. Ditto for making the shopping list with ingredients that overlap (I tried to avoid this in a big way). 

                );
            builder.Entity<Recipe>()
                .HasData(
                    // this recipe is 8 servings base
                    new Recipe { RecipeId = 1, RecipeName = "Spaghetti with Meat Sauce", BaseServings = 8, CostPerServing = 1.00m, PrepTime = "Prep: 15 min. Total: 1 hour and 15 min.", Directions = "1) Combine ground beef, diced onion, and finely chopped garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low. 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left on sauce, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.", NutritionInfo = "Over 20 grams of protein per serving. Approx. 10 grams of fiber per serving. Less than 10g of sugar per serving.", RecipeTips = "For an even healthier variation, trying mixing in fresh or frozen vegetables like broccoli, spinach, Refrigerate leftover sauce and pasta in separate containers for better flavor. Leftover sauce can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop."},
                    
                   
                    new Recipe { RecipeId = 2, RecipeName = "Mac and Cheese Tuna Casserole", BaseServings = 4, CostPerServing = 2.28m, PrepTime = "Prep: 5 min. Total: 20 min.", Directions = "1) Boil macaroni according to package instructions. 2) While cooking macaroni, steam brocolli in microwave or covered pot with vegetable steamer on the stovetop until tender. 2) Open tuna and drain excess water from both the tuna and steamed broccoli. 3) Strain macaroni and mix in steamed brocolli, box cheesepackets, a handful per serving of grated cheddar cheese, a splash of milk, and tuna. 4) Return this mixture to the microwave or stovetop and heat on medium,stirring frequently, until cheese is completely melted (optional: sprinkle grated cheese on top in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season sparingly with salt and pepper(optional: try with either creole seasoning or lemon pepper, but make sure to add these before salt, as both usually contain salt).", NutritionInfo = "Over 20g of protein per serving. Less than 6g of sugar per serving. Great source of calcium and iron.", RecipeTips = "This recipe will leave you with some leftover cheese and milk; double the recipe size to use more of these two ingredients and reduce the cost per serving by 25%, or save for breakfasts and snacks. Refrigerate leftover casserole for up to four days in a sealed container." },
                    
                    
                    new Recipe { RecipeId = 3, RecipeName = "Healthy Pre-Packaged Ramen Noodles", BaseServings = 4, CostPerServing = 1.52m, PrepTime = "Prep: 15 min. Total: 20min.", Directions = "Note: you will need cooking oil for this recipe. Make sure to multitask steps 1 and 2 for fast prep. 1) Add a thin layer of oil to a large skillet. Prepare 1/2 diced onion, 1/2 container of siced mushrooms, and 1/4 of the tofu package diced into cubes for every 2 servings you need. When the oil is hot, add onion, mushrooms, and tofu and cook over medium heat until onion is transluscent and tofu is lightly browned, flipping ingredients regularly (approx 10 minutes). 2) Boil a medium-large pot of water and add one egg (shell on or off) for every two servings you will be preparing. Add ramen noodles (without seasoning) after 5 minutes for hard boiled eggs, 3 minutes for soft boiled/poached eggs, or at the same time for egg-drop-soup style ramen (make sure to use a minimal amount of water if you choose this option). 3) Follow  instructions on the bag to steam frozen vegetables in the microwave, straining out any residual water afterwards and setting aside 1/2 bag per two servings for the ramen. 4) After 4-5 minutes at a boil, pour out excess water from the egg/ramen pot if you prefer less broth. Mix in the grilled/steamed vegetables and tofu, peel and slice hard/soft boiled eggs, and season lightly with ramen flavor packets (optional healthy substitutes for flavor packets: soy sauce, ginger paste, chili flakes, sriracha, and hot sauce).", NutritionInfo = "15 grams of protein per serving. 5 grams of fiber per serving. Less than 5 grams of sugar per serving.", RecipeTips = "If you make four servings of this meal, you will likely have leftover eggs, tofu, and onion; double the recipe size to use almost all of these leftover ingredients and reduce the cost per serving by over 50%. Firm tofu has a mild flavor and can be supplemented into almost any recipe for extra protein, fiber, and vitamins. Refrigerate leftover ramen for up to a week (use single serving plastic or glass storage containers that are microwave safe for  readymade lunches" },
                    // this recipe has a base serving size of 4
                    new Recipe { RecipeId = 4, RecipeName = "Peanut Butter, Banana, Honey Oatmeal", BaseServings = 4, CostPerServing = 1.79m, PrepTime = "Prep: 1 min. Total: 10 min. ", Directions = "1) Bring a large pot of water to boil and add 2 cups of oats (approx. 1/4 of 18oz container) and a pinch of salt. 2) Cook on medium heat for 5 minutes, stirring frequently. 3) Remove from heat, add milk or warm water if oats are too thick, and mix in 1 sliced banana, 2 heaping spoonfuls of peanut butter, and two level spoonfuls of honey per 2 servings.", NutritionInfo = "Over 10 grams of protein per serving. Approx. 8 grams of fiber per serving. High in Iron and Potassium.", RecipeTips = "This recipe is highyly cost effective over time; all ingredients are shelf-stable and will cost under 50 cents per serving if prepared regularly. Store leftover oatmeal in single-serving plastic or glass storage containers that are microwave safe for fast and easy breakfasts and lunches, or use leftover oatmeal mixed with nuts or chocolate chips to make healthy cookie bars; spoon oatmeal and mixins onto a baking sheet and cook at 300 degrees until lightly browned, for approx. 10 minutes." },
                    
                    new Recipe { RecipeId = 5, RecipeName = "Beef Chili", BaseServings = 6, CostPerServing = 1.36m, PrepTime = "Prep: 10 min. Total: 40 min. ", Directions = "1) Add ground beef and chili seasoning/chili powder to a large skillet and cook medium-high until browned. 2) Add diced onion, bell pepper, and garlic, cooking over medium heat and stirring regularly until onion is translucent. 3) Add diced tomatoes(drained), green chiles(drained), and beans (undrained), return to a boil, and reduce heat to medium-low. Simmer for 20 minutes, stirring occasionally. 4) Season with salt and pepper to taste (optional: try with additional spices, like cumin, oregano, or mix in a dash of brown sugar or hot sauce).", NutritionInfo = "25g of protein per serving. About 10 grams of fiber per serving. Very high in iron and calcium.", RecipeTips = "Leftover chili can be stored in the refrigerator for up to five days can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop." },
                    // this recipe has a base serving size of 8
                    new Recipe { RecipeId = 6, RecipeName = "Sausage, Mushroom, and Spinach Frittata", BaseServings = 8, CostPerServing = 1.44m, PrepTime = "Prep: 15 min. Total: 35 min. ", Directions = "Note: you will need cooking oil for this recipe. 1) Wash potato, poke a few holes in skin with a fork, and microwave for 3-5 minutes. After allowing to cool slightly, roughly chop potato. 2) Meanwhile, add ground pork to a large preheated skillet and cook on medium heat until cooked through (note: if you are using precooked breakfast sausage, wait to add sausage until the next step). 3) Add a splash of oil and full package of sliced mushrooms to skillet and continue to cook on medium-high until pork is browned and mushrooms have started to soften. 4) In a large bowl, beat eggs, a dash of salt and pepper, and any additional desired spices with a whisk or fork until frothy. 5) Pour eggs into skillet, mixing in chopped potato, spinach (lightly shred if leaves are large), and lightly sprinkle with shredded cheese (optional: add a splash of milk for fluffier consistency). Mix ingredients quickly to distribute and then Cook for 2 minutes on medium high; if using a small burner, slide skillet occasionally to ensure even cooking along the bottom of the pan. 6) Reduce to medium-low heat, cover, and cook for 15-20 minutes, or until eggs have set. 7) After cooling slightly, cut into 8 even wedges.", NutritionInfo = "Approx. 20g of protein per serving. High in iron, potassium, and calcium.", RecipeTips = "Leftover fritatta can be stored in the refrigerator for 3 days or frozen in ziplock bags. Individually wrap leftover slices for lunch and eat warm or cold." }

                );
            builder.Entity<IngredientRecipe>()
                .HasData(
                    new IngredientRecipe { IngredientRecipeId = 1, RecipeId = 1, IngredientId = 1 },
                    new IngredientRecipe { IngredientRecipeId = 2, RecipeId = 1, IngredientId = 2 },
                    new IngredientRecipe { IngredientRecipeId = 3, RecipeId = 1, IngredientId = 3 },
                    new IngredientRecipe { IngredientRecipeId = 4, RecipeId = 1, IngredientId = 4 },
                    new IngredientRecipe { IngredientRecipeId = 5, RecipeId = 1, IngredientId = 5 },
                    new IngredientRecipe { IngredientRecipeId = 6, RecipeId = 1, IngredientId = 6 },
                    new IngredientRecipe { IngredientRecipeId = 7, RecipeId = 2, IngredientId = 7 },
                    new IngredientRecipe { IngredientRecipeId = 8, RecipeId = 2, IngredientId = 8 },
                    new IngredientRecipe { IngredientRecipeId = 9, RecipeId = 2, IngredientId = 9 },
                    new IngredientRecipe { IngredientRecipeId = 10, RecipeId = 2, IngredientId = 10 },
                    new IngredientRecipe { IngredientRecipeId = 11, RecipeId = 2, IngredientId = 11 },
                    new IngredientRecipe { IngredientRecipeId = 12, RecipeId = 3, IngredientId = 12 },
                    new IngredientRecipe { IngredientRecipeId = 13, RecipeId = 3, IngredientId = 13 },
                    new IngredientRecipe { IngredientRecipeId = 14, RecipeId = 3, IngredientId = 14 },
                    new IngredientRecipe { IngredientRecipeId = 15, RecipeId = 3, IngredientId = 15 },
                    new IngredientRecipe { IngredientRecipeId = 16, RecipeId = 3, IngredientId = 16 },
                    new IngredientRecipe { IngredientRecipeId = 17, RecipeId = 3, IngredientId = 4 },
                    new IngredientRecipe { IngredientRecipeId = 18, RecipeId = 4, IngredientId = 17 },
                    new IngredientRecipe { IngredientRecipeId = 19, RecipeId = 4, IngredientId = 18 },
                    new IngredientRecipe { IngredientRecipeId = 20, RecipeId = 4, IngredientId = 19 },
                    new IngredientRecipe { IngredientRecipeId = 21, RecipeId = 5, IngredientId = 4 },
                    new IngredientRecipe { IngredientRecipeId = 22, RecipeId = 5, IngredientId = 5 },
                    new IngredientRecipe { IngredientRecipeId = 23, RecipeId = 5, IngredientId = 6 },
                    new IngredientRecipe { IngredientRecipeId = 24, RecipeId = 5, IngredientId = 20 },
                    new IngredientRecipe { IngredientRecipeId = 25, RecipeId = 5, IngredientId = 21 },
                    new IngredientRecipe { IngredientRecipeId = 26, RecipeId = 5, IngredientId = 22 },
                    new IngredientRecipe { IngredientRecipeId = 27, RecipeId = 5, IngredientId = 23 },
                    new IngredientRecipe { IngredientRecipeId = 28, RecipeId = 6, IngredientId = 24 },
                    new IngredientRecipe { IngredientRecipeId = 29, RecipeId = 6, IngredientId = 25 },
                    new IngredientRecipe { IngredientRecipeId = 30, RecipeId = 6, IngredientId = 26 },
                    new IngredientRecipe { IngredientRecipeId = 31, RecipeId = 6, IngredientId = 27 },
                    new IngredientRecipe { IngredientRecipeId = 32, RecipeId = 6, IngredientId = 10 },
                    new IngredientRecipe { IngredientRecipeId = 33, RecipeId = 6, IngredientId = 12 }
                );
                    
         }
    }
}



