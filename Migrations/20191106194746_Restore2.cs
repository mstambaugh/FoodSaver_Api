using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class Restore2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PricePerServing",
                table: "Recipes",
                newName: "CostPerServing");

            migrationBuilder.AddColumn<int>(
                name: "BaseServings",
                table: "Recipes",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "IngredientSubstitution",
                value: "jar tomato basil or marinara pasta sauce, 8oz tube of tomato paste diluted per instructions");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                columns: new[] { "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { 3, "garlic powder, garlic paste" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "IngredientPrice",
                value: 1.50m);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { "3oz  package of flavored ramen noodle soup (Maruchan is the most widely available brand)", 0.60m, 3, "thin whole wheat ramen noodles or instant ramen cup noodles" });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "IngredientId", "IngredientName", "IngredientPrice", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[,]
                {
                    { 27, "dozen large eggs", 1.29m, 1, "none" },
                    { 26, "bunch fresh spinach", 1.48m, 1, "small bag frozen spinach, 8oz can spinach in water(drained)" },
                    { 25, "large idaho/russet potato", 0.52m, 1, "2 large red or yellow potatoes" },
                    { 24, "lb ground pork sausage", 2.88m, 1, "12oz fresh or frozen sausage links or patties" },
                    { 23, "14-15oz can diced tomatoes", 0.46m, 1, "can chili ready tomatoes or whole peeled tomatoes (slice to prep)" },
                    { 22, "fresh bell pepper", 1.00m, 1, "red, orange, or yellow pepper, small bag frozen bell peppers" },
                    { 21, "4oz can diced green chiles", 0.76m, 1, "4 oz can roasted green chiles" },
                    { 20, "15oz can pinto beans", 1.74m, 3, "15oz canned red, black, kidney, or mixed beans" },
                    { 18, "18 oz tub creamy peanut butter", 2.00m, 1, "crunchy peanut butter, reduced fat peanut butter" },
                    { 17, "large banana", 0.42m, 2, "18oz quick oats, bulk size rolled oats, " },
                    { 16, "18 oz container rolled oats", 1.76m, 1, "18oz quick oats or bulk size rolled oats" },
                    { 15, "12 oz bag of frozen mixed vegetables", 0.85m, 1, " brocolli, califlower, carrots, and green beans" },
                    { 14, "14oz package extra-firm tofu", 1.44m, 1, "cooked and shredded chicken, pork, or beef" },
                    { 13, "half-dozen eggs", 0.50m, 2, "dozen egg carton" },
                    { 12, "8oz package pre-sliced white or brown mushrooms", 1.98m, 1, "8 oz unsliced fresh mushrooms or small package dried shitake mushrooms" },
                    { 19, "16 oz bear of honey", 2.98m, 1, " brown sugar, cinnamon sugar, maple syrup" }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "BaseServings", "Directions", "PrepTime", "RecipeName" },
                values: new object[] { 8, "1) Combine ground beef, diced onion, and finely chopped garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.", "Prep: 15 min. Total: 1 hour and 15 min.", "Spaghetti with Meat Sauce" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "BaseServings", "PrepTime", "RecipeName", "RecipeTips" },
                values: new object[] { 4, "Prep: 5 min. Total: 20 min.", "Mac and Cheese Tuna Casserole", "This recipe will leave you with some leftover cheese and milk; double the recipe size to use more of these two ingredients and reduce the cost per serving by 25%, or save for breakfasts and snacks. Refrigerate leftover casserole for up to four days in a sealed container." });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "RecipeId", "BaseServings", "CostPerServing", "Directions", "NutritionInfo", "PrepTime", "RecipeName", "RecipeTips" },
                values: new object[,]
                {
                    { 5, 6, 1.36m, "1) Add ground beef and chili seasoning/chili powder to a large skillet and cook medium-high until browned 2) Add diced onion, bell pepper, and garlic, cooking over medium heat and stirring regularly until onion is translucent. 3) Add diced tomatoes(drained), green chiles(drained), and beans (undrained), return to a boil, and reduce heat to medium-low and simmer for 20 minutes, stirring occasionally. 4) Season with salt and pepper to taste (optional: try with additional spices, like cumin, oregano, or mix in a dash of brown sugar or hot sauce to taste.", "25g of protein per serving. About 10 grams of fiber per serving. Very high in iron and calcium.", "Prep: 10 min. Total: 40 min. ", "Beef Chili", "Leftover chili can be stored in the refrigerator for up to five days can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop." },
                    { 3, 4, 1.52m, "Note: you will need cooking oil for this recipe. Make sure to multitask steps 1 and 2 for fast prep. 1) Add a thin layer of oil to a large skillet. Prepare 1/2 diced onion, 1/2 container of siced mushrooms, and 1/4 of the tofu package diced into cubes for every 2 servings you need. When the oil is hot, add onion, mushrooms, and tofu and cook over medium heat until onion is transluscent and tofu is lightly browned, flipping ingredients regularly (approx 10 minutes). 2) Boil a medium-large pot of water and add one egg (shell on or off) for every two servings you will be preparing. Add ramen noodles (without seasoning) after 5 minutes for hard boiled eggs, 3 minutes for soft boiled/poached eggs, or at the same time for egg-drop-soup style ramen (make sure to use a minimal amount of water if you choose this option). 3) Follow  instructions on the bag to steam frozen vegetables in the microwave, straining out any residual water afterwards and setting aside 1/2 bag per two servings for the ramen. 4) After 4-5 minutes at a boil, pour out excess water from the egg/ramen pot if you prefer less broth. Mix in the grilled/steamed vegetables and tofu, peel and slice hard/soft boiled eggs, and season lightly with ramen flavor packets (optional healthy substitutes for flavor packets: soy sauce, ginger paste, chili flakes, sriracha, and hot sauce).", "15 grams of protein per serving. 5 grams of fiber per serving. Less than 5 grams of sugar per serving.", "Prep: 15 min. Total: 20min.", "Healthy Pre-Packaged Ramen Noodles", "If you make four servings of this meal, you will likely have leftover eggs, tofu, and onion; double the recipe size to use almost all of these leftover ingredients and reduce the cost per serving by over 50%. Firm tofu has a mild flavor and can be supplemented into almost any recipe for extra protein, fiber, and vitamins. Refrigerate leftover ramen for up to a week (use single serving plastic or glass storage containers that are microwave safe for  readymade lunches" },
                    { 4, 4, 1.79m, "1) Bring a large pot of water to boil and add 2 cups of oats (approx. 1/4 of 18oz container) and a pinch of salt. 2) Cook on medium heat for 5 minutes, stirring frequently. 3) Remove from heat, add milk or warm water if oats are too thick, and mix in 1 sliced banana, 2 heaping spoonfuls of peanut butter, and two level spoonfuls of honey per 2 servings.", "Over 10 grams of protein per serving. Approx. 8 grams of fiber per serving. High in Iron and Potassium.", "Prep: 1 min. Total: 10 min. ", "Peanut Butter, Banana, Honey Oatmeal", "This recipe is highyly cost effective over time; all ingredients are shelf-stable and under 50 cents per serving over time. Store leftover oatmeal in single serving plastic or glass storage containers that are microwave safe for fast and easy breakfasts and lunches, or use leftover oatmeal mixed with nuts or chocolate chips to make healthy cookie bars (spoon oatmeal and mixins onto a baking sheet and bake at 300 until lightly browned, approx. 10 minutes)." },
                    { 6, 8, 1.44m, "Note: you will need cooking oil for this recipe. 1) Wash potato, poke a few holes in skin with a fork, and microwave for 3-5 minutes. After allowing to cool slightly, roughly chop potato. 2) Add ground pork to a large preheated skillet and cook on medium heat until cooked through (note: if you are using precooked breakfast sausage, wait to add sausage until the next step). 3) Add a splash of oil and full package of sliced mushrooms to skillet and continue to cook on medium-high until pork is browned and mushrooms have started to soften. 4) In a large bowl, beat eggs, a dash of salt and pepper, and any additional desired spices with a whisk or fork until frothy. 5) Pour eggs into skillet, mixing in chopped potato, spinach (lightly shred if leaves are large), and lightly sprinkle with shredded cheese (optional: add a splash of milk for fluffier consistency). Mix ingredients quickly to distribute and then Cook for 2 minutes on medium high; if using a small burner, slide skillet occasionally to ensure even cooking along the bottom of the pan. 6) Reduce to medium-low heat, cover, and cook for 15-20 minutes, or until eggs have set. 7) After cooling slightly, cut across into 8 even wedges.", "Approx 20g of protein per serving. High in iron, potassium, and calcium.", "Prep: 15 min. Total: 35 min. ", "Sausage, Mushroom, and Spinach Frittata", "Leftover fritatta can be stored in the refrigerator for 3 days. Individually wrap leftover slices for easy lunches." }
                });

            migrationBuilder.InsertData(
                table: "IngredientRecipes",
                columns: new[] { "IngredientRecipeId", "IngredientId", "RecipeId" },
                values: new object[,]
                {
                    { 12, 12, 3 },
                    { 31, 27, 6 },
                    { 30, 26, 6 },
                    { 29, 25, 6 },
                    { 28, 24, 6 },
                    { 27, 23, 5 },
                    { 26, 22, 5 },
                    { 25, 21, 5 },
                    { 24, 20, 5 },
                    { 23, 6, 5 },
                    { 22, 5, 5 },
                    { 21, 4, 5 },
                    { 20, 19, 4 },
                    { 19, 18, 4 },
                    { 18, 17, 4 },
                    { 17, 4, 3 },
                    { 16, 16, 3 },
                    { 15, 15, 3 },
                    { 14, 14, 3 },
                    { 13, 13, 3 },
                    { 32, 10, 6 },
                    { 33, 12, 6 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "IngredientRecipes",
                keyColumn: "IngredientRecipeId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "BaseServings",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "CostPerServing",
                table: "Recipes",
                newName: "PricePerServing");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 3,
                column: "IngredientSubstitution",
                value: "jar tomato-basil/marinara pasta sauce");

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 5,
                columns: new[] { "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { 4, "garlic powder, italian seasoning" });

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 7,
                column: "IngredientPrice",
                value: 0.75m);

            migrationBuilder.UpdateData(
                table: "Ingredients",
                keyColumn: "IngredientId",
                keyValue: 11,
                columns: new[] { "IngredientName", "IngredientPrice", "IngredientQuantity", "IngredientSubstitution" },
                values: new object[] { "5oz can chunk light tuna in water", 0.75m, 2, "5oz can tuna of any variety" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                columns: new[] { "Directions", "PrepTime", "RecipeName" },
                values: new object[] { "1) Combine ground beef, onion, and garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.", "Prep: 15 min Total: 1 hour and 15 min", "Spaghetti with Beef Marinara" });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                columns: new[] { "PrepTime", "RecipeName", "RecipeTips" },
                values: new object[] { "Prep: 5 min Total: 20 min", "Speedy Mac and Cheese Tuna Casserole", "This recipe will leave you with some leftover cheese and milk; double the recipe size to use up more of these two ingredients, or save for breakfasts and snacks. Refrigerate leftover casserole for up to four days in a sealed container." });
        }
    }
}
