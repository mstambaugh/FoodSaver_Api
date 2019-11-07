using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodSaverAPI.Migrations
{
    public partial class EpicodusMac : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Directions",
                value: "1) Combine ground beef, diced onion, and finely chopped garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low. 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left on sauce, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Directions",
                value: "1) Boil macaroni according to package instructions. 2) While cooking macaroni, steam brocolli in microwave or covered pot with vegetable steamer on the stovetop until tender. 2) Open tuna and drain excess water from both the tuna and steamed broccoli. 3) Strain macaroni and mix in steamed brocolli, box cheesepackets, a handful per serving of grated cheddar cheese, a splash of milk, and tuna. 4) Return this mixture to the microwave or stovetop and heat on medium,stirring frequently, until cheese is completely melted (optional: sprinkle grated cheese on top in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season sparingly with salt and pepper(optional: try with either creole seasoning or lemon pepper, but make sure to add these before salt, as both usually contain salt).");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "RecipeTips",
                value: "This recipe is highyly cost effective over time; all ingredients are shelf-stable and will cost under 50 cents per serving if prepared regularly. Store leftover oatmeal in single-serving plastic or glass storage containers that are microwave safe for fast and easy breakfasts and lunches, or use leftover oatmeal mixed with nuts or chocolate chips to make healthy cookie bars; spoon oatmeal and mixins onto a baking sheet and cook at 300 degrees until lightly browned, for approx. 10 minutes.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Directions",
                value: "1) Add ground beef and chili seasoning/chili powder to a large skillet and cook medium-high until browned. 2) Add diced onion, bell pepper, and garlic, cooking over medium heat and stirring regularly until onion is translucent. 3) Add diced tomatoes(drained), green chiles(drained), and beans (undrained), return to a boil, and reduce heat to medium-low. Simmer for 20 minutes, stirring occasionally. 4) Season with salt and pepper to taste (optional: try with additional spices, like cumin, oregano, or mix in a dash of brown sugar or hot sauce).");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                columns: new[] { "Directions", "NutritionInfo", "RecipeTips" },
                values: new object[] { "Note: you will need cooking oil for this recipe. 1) Wash potato, poke a few holes in skin with a fork, and microwave for 3-5 minutes. After allowing to cool slightly, roughly chop potato. 2) Meanwhile, add ground pork to a large preheated skillet and cook on medium heat until cooked through (note: if you are using precooked breakfast sausage, wait to add sausage until the next step). 3) Add a splash of oil and full package of sliced mushrooms to skillet and continue to cook on medium-high until pork is browned and mushrooms have started to soften. 4) In a large bowl, beat eggs, a dash of salt and pepper, and any additional desired spices with a whisk or fork until frothy. 5) Pour eggs into skillet, mixing in chopped potato, spinach (lightly shred if leaves are large), and lightly sprinkle with shredded cheese (optional: add a splash of milk for fluffier consistency). Mix ingredients quickly to distribute and then Cook for 2 minutes on medium high; if using a small burner, slide skillet occasionally to ensure even cooking along the bottom of the pan. 6) Reduce to medium-low heat, cover, and cook for 15-20 minutes, or until eggs have set. 7) After cooling slightly, cut into 8 even wedges.", "Approx. 20g of protein per serving. High in iron, potassium, and calcium.", "Leftover fritatta can be stored in the refrigerator for 3 days or frozen in ziplock bags. Individually wrap leftover slices for lunch and eat warm or cold." });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 1,
                column: "Directions",
                value: "1) Combine ground beef, diced onion, and finely chopped garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 2,
                column: "Directions",
                value: "1)Boil macaroni according to package instructions. 2) While cooking macaroni, steam brocolli in microwave or covered pot with vegetable steamer on the stovetop until tender. 2) Open tuna and drain excess water from both the tuna and steamed broccoli. 3) Strain macaroni and mix in steamed brocolli, cheesepacket, 1 handful per serving of grated cheddar cheese, a splash of milk, and tuna. 4) Return this mixture to the microwave or stovetop and heat on medium,stirring frequently, until cheese is completely melted (optional: sprinkle grated cheese on top in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season sparingly with salt and pepper(optional: try with either creole seasoning or lemon pepper. Just make sure to add before salt, as both seasoning mixes usually contain salt).");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 4,
                column: "RecipeTips",
                value: "This recipe is highyly cost effective over time; all ingredients are shelf-stable and under 50 cents per serving over time. Store leftover oatmeal in single serving plastic or glass storage containers that are microwave safe for fast and easy breakfasts and lunches, or use leftover oatmeal mixed with nuts or chocolate chips to make healthy cookie bars (spoon oatmeal and mixins onto a baking sheet and bake at 300 until lightly browned, approx. 10 minutes).");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 5,
                column: "Directions",
                value: "1) Add ground beef and chili seasoning/chili powder to a large skillet and cook medium-high until browned 2) Add diced onion, bell pepper, and garlic, cooking over medium heat and stirring regularly until onion is translucent. 3) Add diced tomatoes(drained), green chiles(drained), and beans (undrained), return to a boil, and reduce heat to medium-low and simmer for 20 minutes, stirring occasionally. 4) Season with salt and pepper to taste (optional: try with additional spices, like cumin, oregano, or mix in a dash of brown sugar or hot sauce to taste.");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "RecipeId",
                keyValue: 6,
                columns: new[] { "Directions", "NutritionInfo", "RecipeTips" },
                values: new object[] { "Note: you will need cooking oil for this recipe. 1) Wash potato, poke a few holes in skin with a fork, and microwave for 3-5 minutes. After allowing to cool slightly, roughly chop potato. 2) Add ground pork to a large preheated skillet and cook on medium heat until cooked through (note: if you are using precooked breakfast sausage, wait to add sausage until the next step). 3) Add a splash of oil and full package of sliced mushrooms to skillet and continue to cook on medium-high until pork is browned and mushrooms have started to soften. 4) In a large bowl, beat eggs, a dash of salt and pepper, and any additional desired spices with a whisk or fork until frothy. 5) Pour eggs into skillet, mixing in chopped potato, spinach (lightly shred if leaves are large), and lightly sprinkle with shredded cheese (optional: add a splash of milk for fluffier consistency). Mix ingredients quickly to distribute and then Cook for 2 minutes on medium high; if using a small burner, slide skillet occasionally to ensure even cooking along the bottom of the pan. 6) Reduce to medium-low heat, cover, and cook for 15-20 minutes, or until eggs have set. 7) After cooling slightly, cut across into 8 even wedges.", "Approx 20g of protein per serving. High in iron, potassium, and calcium.", "Leftover fritatta can be stored in the refrigerator for 3 days. Individually wrap leftover slices for easy lunches." });
        }
    }
}
