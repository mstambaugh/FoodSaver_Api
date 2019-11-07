﻿// <auto-generated />
using FoodSaverApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodSaverAPI.Migrations
{
    [DbContext(typeof(FoodSaverApiContext))]
    [Migration("20191107213104_Imageupdate")]
    partial class Imageupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FoodSaverApi.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IngredientName");

                    b.Property<decimal>("IngredientPrice");

                    b.Property<int>("IngredientQuantity");

                    b.Property<string>("IngredientSubstitution");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            IngredientName = "lb wheat spaghetti",
                            IngredientPrice = 1.20m,
                            IngredientQuantity = 2,
                            IngredientSubstitution = "lb wheat/whole grain pasta"
                        },
                        new
                        {
                            IngredientId = 2,
                            IngredientName = "28oz can diced tomatoes",
                            IngredientPrice = 1.10m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "double tomato sauce quantity"
                        },
                        new
                        {
                            IngredientId = 3,
                            IngredientName = "16oz can tomato sauce",
                            IngredientPrice = 0.60m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "jar tomato basil or marinara pasta sauce, 8oz tube of tomato paste diluted per instructions"
                        },
                        new
                        {
                            IngredientId = 4,
                            IngredientName = "large onion",
                            IngredientPrice = 0.70m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "onion powder, diced vegetable"
                        },
                        new
                        {
                            IngredientId = 5,
                            IngredientName = "cloves garlic",
                            IngredientPrice = 0.50m,
                            IngredientQuantity = 3,
                            IngredientSubstitution = "garlic powder, garlic paste"
                        },
                        new
                        {
                            IngredientId = 6,
                            IngredientName = "lb ground beef chuck 80/20",
                            IngredientPrice = 3.00m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "lb fresh or frozen ground beef/turkey/lean pork."
                        },
                        new
                        {
                            IngredientId = 7,
                            IngredientName = "7-9oz box white cheddar macaroni and cheese",
                            IngredientPrice = 1.50m,
                            IngredientQuantity = 2,
                            IngredientSubstitution = "any flavor boxed macaroni and cheese"
                        },
                        new
                        {
                            IngredientId = 8,
                            IngredientName = "12oz frozen broccoli",
                            IngredientPrice = 1.00m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "12oz steam-in-bag frozen vegetable/vegetable mixes"
                        },
                        new
                        {
                            IngredientId = 9,
                            IngredientName = "1/2 gallon 2% milk",
                            IngredientPrice = 1.75m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "any variety of milk or non-dairy milk"
                        },
                        new
                        {
                            IngredientId = 10,
                            IngredientName = "8oz white cheddar cheese block",
                            IngredientPrice = 3.36m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "any variety of cheddar cheese- save by avoiding pre-shredded options"
                        },
                        new
                        {
                            IngredientId = 11,
                            IngredientName = "3oz  package of flavored ramen noodle soup (Maruchan is the most widely available brand)",
                            IngredientPrice = 0.60m,
                            IngredientQuantity = 3,
                            IngredientSubstitution = "thin whole wheat ramen noodles or instant ramen cup noodles"
                        },
                        new
                        {
                            IngredientId = 12,
                            IngredientName = "8oz package pre-sliced white or brown mushrooms",
                            IngredientPrice = 1.98m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "8 oz unsliced fresh mushrooms or small package dried shitake mushrooms"
                        },
                        new
                        {
                            IngredientId = 13,
                            IngredientName = "half-dozen eggs",
                            IngredientPrice = 0.50m,
                            IngredientQuantity = 2,
                            IngredientSubstitution = "dozen egg carton"
                        },
                        new
                        {
                            IngredientId = 14,
                            IngredientName = "14oz package extra-firm tofu",
                            IngredientPrice = 1.44m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "cooked and shredded chicken, pork, or beef"
                        },
                        new
                        {
                            IngredientId = 15,
                            IngredientName = "12 oz bag of frozen mixed vegetables",
                            IngredientPrice = 0.85m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = " brocolli, califlower, carrots, and green beans"
                        },
                        new
                        {
                            IngredientId = 16,
                            IngredientName = "18 oz container rolled oats",
                            IngredientPrice = 1.76m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "18oz quick oats or bulk size rolled oats"
                        },
                        new
                        {
                            IngredientId = 17,
                            IngredientName = "large banana",
                            IngredientPrice = 0.42m,
                            IngredientQuantity = 2,
                            IngredientSubstitution = "18oz quick oats, bulk size rolled oats, "
                        },
                        new
                        {
                            IngredientId = 18,
                            IngredientName = "18 oz tub creamy peanut butter",
                            IngredientPrice = 2.00m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "crunchy peanut butter, reduced fat peanut butter"
                        },
                        new
                        {
                            IngredientId = 19,
                            IngredientName = "16 oz bear of honey",
                            IngredientPrice = 2.98m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = " brown sugar, cinnamon sugar, maple syrup"
                        },
                        new
                        {
                            IngredientId = 20,
                            IngredientName = "15oz can pinto beans",
                            IngredientPrice = 1.74m,
                            IngredientQuantity = 3,
                            IngredientSubstitution = "15oz canned red, black, kidney, or mixed beans"
                        },
                        new
                        {
                            IngredientId = 21,
                            IngredientName = "4oz can diced green chiles",
                            IngredientPrice = 0.76m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "4 oz can roasted green chiles"
                        },
                        new
                        {
                            IngredientId = 22,
                            IngredientName = "fresh bell pepper",
                            IngredientPrice = 1.00m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "red, orange, or yellow pepper, small bag frozen bell peppers"
                        },
                        new
                        {
                            IngredientId = 23,
                            IngredientName = "14-15oz can diced tomatoes",
                            IngredientPrice = 0.46m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "can chili ready tomatoes or whole peeled tomatoes (slice to prep)"
                        },
                        new
                        {
                            IngredientId = 24,
                            IngredientName = "lb ground pork sausage",
                            IngredientPrice = 2.88m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "12oz fresh or frozen sausage links or patties"
                        },
                        new
                        {
                            IngredientId = 25,
                            IngredientName = "large idaho/russet potato",
                            IngredientPrice = 0.52m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "2 large red or yellow potatoes"
                        },
                        new
                        {
                            IngredientId = 26,
                            IngredientName = "bunch fresh spinach",
                            IngredientPrice = 1.48m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "small bag frozen spinach, 8oz can spinach in water(drained)"
                        },
                        new
                        {
                            IngredientId = 27,
                            IngredientName = "dozen large eggs",
                            IngredientPrice = 1.29m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "none"
                        });
                });

            modelBuilder.Entity("FoodSaverApi.Models.IngredientRecipe", b =>
                {
                    b.Property<int>("IngredientRecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IngredientId");

                    b.Property<int>("RecipeId");

                    b.HasKey("IngredientRecipeId");

                    b.HasIndex("IngredientId");

                    b.HasIndex("RecipeId");

                    b.ToTable("IngredientRecipes");

                    b.HasData(
                        new
                        {
                            IngredientRecipeId = 1,
                            IngredientId = 1,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientRecipeId = 2,
                            IngredientId = 2,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientRecipeId = 3,
                            IngredientId = 3,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientRecipeId = 4,
                            IngredientId = 4,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientRecipeId = 5,
                            IngredientId = 5,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientRecipeId = 6,
                            IngredientId = 6,
                            RecipeId = 1
                        },
                        new
                        {
                            IngredientRecipeId = 7,
                            IngredientId = 7,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientRecipeId = 8,
                            IngredientId = 8,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientRecipeId = 9,
                            IngredientId = 9,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientRecipeId = 10,
                            IngredientId = 10,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientRecipeId = 11,
                            IngredientId = 11,
                            RecipeId = 2
                        },
                        new
                        {
                            IngredientRecipeId = 12,
                            IngredientId = 12,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientRecipeId = 13,
                            IngredientId = 13,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientRecipeId = 14,
                            IngredientId = 14,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientRecipeId = 15,
                            IngredientId = 15,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientRecipeId = 16,
                            IngredientId = 16,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientRecipeId = 17,
                            IngredientId = 4,
                            RecipeId = 3
                        },
                        new
                        {
                            IngredientRecipeId = 18,
                            IngredientId = 17,
                            RecipeId = 4
                        },
                        new
                        {
                            IngredientRecipeId = 19,
                            IngredientId = 18,
                            RecipeId = 4
                        },
                        new
                        {
                            IngredientRecipeId = 20,
                            IngredientId = 19,
                            RecipeId = 4
                        },
                        new
                        {
                            IngredientRecipeId = 21,
                            IngredientId = 4,
                            RecipeId = 5
                        },
                        new
                        {
                            IngredientRecipeId = 22,
                            IngredientId = 5,
                            RecipeId = 5
                        },
                        new
                        {
                            IngredientRecipeId = 23,
                            IngredientId = 6,
                            RecipeId = 5
                        },
                        new
                        {
                            IngredientRecipeId = 24,
                            IngredientId = 20,
                            RecipeId = 5
                        },
                        new
                        {
                            IngredientRecipeId = 25,
                            IngredientId = 21,
                            RecipeId = 5
                        },
                        new
                        {
                            IngredientRecipeId = 26,
                            IngredientId = 22,
                            RecipeId = 5
                        },
                        new
                        {
                            IngredientRecipeId = 27,
                            IngredientId = 23,
                            RecipeId = 5
                        },
                        new
                        {
                            IngredientRecipeId = 28,
                            IngredientId = 24,
                            RecipeId = 6
                        },
                        new
                        {
                            IngredientRecipeId = 29,
                            IngredientId = 25,
                            RecipeId = 6
                        },
                        new
                        {
                            IngredientRecipeId = 30,
                            IngredientId = 26,
                            RecipeId = 6
                        },
                        new
                        {
                            IngredientRecipeId = 31,
                            IngredientId = 27,
                            RecipeId = 6
                        },
                        new
                        {
                            IngredientRecipeId = 32,
                            IngredientId = 10,
                            RecipeId = 6
                        },
                        new
                        {
                            IngredientRecipeId = 33,
                            IngredientId = 12,
                            RecipeId = 6
                        });
                });

            modelBuilder.Entity("FoodSaverApi.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BaseServings");

                    b.Property<decimal>("CostPerServing");

                    b.Property<string>("Directions");

                    b.Property<string>("NutritionInfo");

                    b.Property<string>("PrepTime");

                    b.Property<string>("RecipeName");

                    b.Property<string>("RecipePhoto");

                    b.Property<string>("RecipeTips");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            BaseServings = 8,
                            CostPerServing = 1.00m,
                            Directions = "1) Combine ground beef, diced onion, and finely chopped garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low. 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left on sauce, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.",
                            NutritionInfo = "Over 20 grams of protein per serving. Approx. 10 grams of fiber per serving. Less than 10g of sugar per serving.",
                            PrepTime = "Prep: 15 min. Total: 1 hour and 15 min.",
                            RecipeName = "Spaghetti with Meat Sauce",
                            RecipePhoto = "https://i.imgur.com/YEUqi46.jpg",
                            RecipeTips = "For an even healthier variation, trying mixing in fresh or frozen vegetables like broccoli, spinach, Refrigerate leftover sauce and pasta in separate containers for better flavor. Leftover sauce can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop."
                        },
                        new
                        {
                            RecipeId = 2,
                            BaseServings = 4,
                            CostPerServing = 2.28m,
                            Directions = "1) Boil macaroni according to package instructions. 2) While cooking macaroni, steam brocolli in microwave or covered pot with vegetable steamer on the stovetop until tender. 2) Open tuna and drain excess water from both the tuna and steamed broccoli. 3) Strain macaroni and mix in steamed brocolli, box cheesepackets, a handful per serving of grated cheddar cheese, a splash of milk, and tuna. 4) Return this mixture to the microwave or stovetop and heat on medium,stirring frequently, until cheese is completely melted (optional: sprinkle grated cheese on top in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season sparingly with salt and pepper(optional: try with either creole seasoning or lemon pepper, but make sure to add these before salt, as both usually contain salt).",
                            NutritionInfo = "Over 20g of protein per serving. Less than 6g of sugar per serving. Great source of calcium and iron.",
                            PrepTime = "Prep: 5 min. Total: 20 min.",
                            RecipeName = "Box Mac and Cheese Tuna Casserole",
                            RecipePhoto = "https://i.imgur.com/nfV9Ly5.jpg",
                            RecipeTips = "This recipe will leave you with some leftover cheese and milk; double the recipe size to use more of these two ingredients and reduce the cost per serving by 25%, or save for breakfasts and snacks. Refrigerate leftover casserole for up to four days in a sealed container."
                        },
                        new
                        {
                            RecipeId = 3,
                            BaseServings = 4,
                            CostPerServing = 1.52m,
                            Directions = "Note: you will need cooking oil for this recipe. Make sure to multitask steps 1 and 2 for fast prep. 1) Add a thin layer of oil to a large skillet. Prepare 1/2 diced onion, 1/2 container of siced mushrooms, and 1/4 of the tofu package diced into cubes for every 2 servings you need. When the oil is hot, add onion, mushrooms, and tofu and cook over medium heat until onion is transluscent and tofu is lightly browned, flipping ingredients regularly (approx 10 minutes). 2) Boil a medium-large pot of water and add one egg (shell on or off) for every two servings you will be preparing. Add ramen noodles (without seasoning) after 5 minutes for hard boiled eggs, 3 minutes for soft boiled/poached eggs, or at the same time for egg-drop-soup style ramen (make sure to use a minimal amount of water if you choose this option). 3) Follow  instructions on the bag to steam frozen vegetables in the microwave, straining out any residual water afterwards and setting aside 1/2 bag per two servings for the ramen. 4) After 4-5 minutes at a boil, pour out excess water from the egg/ramen pot if you prefer less broth. Mix in the grilled/steamed vegetables and tofu, peel and slice hard/soft boiled eggs, and season lightly with ramen flavor packets (optional healthy substitutes for flavor packets: soy sauce, ginger paste, chili flakes, sriracha, and hot sauce).",
                            NutritionInfo = "15 grams of protein per serving. 5 grams of fiber per serving. Less than 5 grams of sugar per serving.",
                            PrepTime = "Prep: 15 min. Total: 20min.",
                            RecipeName = "Healthy Pre-Packaged Ramen Noodles",
                            RecipePhoto = "https://imgur.com/a/9Gg4CsC",
                            RecipeTips = "If you make four servings of this meal, you will likely have leftover eggs, tofu, and onion; double the recipe size to use almost all of these leftover ingredients and reduce the cost per serving by over 50%. Firm tofu has a mild flavor and can be supplemented into almost any recipe for extra protein, fiber, and vitamins. Refrigerate leftover ramen for up to a week (use single serving plastic or glass storage containers that are microwave safe for  readymade lunches"
                        },
                        new
                        {
                            RecipeId = 4,
                            BaseServings = 4,
                            CostPerServing = 1.79m,
                            Directions = "1) Bring a large pot of water to boil and add 2 cups of oats (approx. 1/4 of 18oz container) and a pinch of salt. 2) Cook on medium heat for 5 minutes, stirring frequently. 3) Remove from heat, add milk or warm water if oats are too thick, and mix in 1 sliced banana, 2 heaping spoonfuls of peanut butter, and two level spoonfuls of honey per 2 servings.",
                            NutritionInfo = "Over 10 grams of protein per serving. Approx. 8 grams of fiber per serving. High in Iron and Potassium.",
                            PrepTime = "Prep: 1 min. Total: 10 min. ",
                            RecipeName = "Peanut Butter, Banana, Honey Oatmeal",
                            RecipePhoto = "https://imgur.com/a/axCi8Jd",
                            RecipeTips = "This recipe is highyly cost effective over time; all ingredients are shelf-stable and will cost under 50 cents per serving if prepared regularly. Store leftover oatmeal in single-serving plastic or glass storage containers that are microwave safe for fast and easy breakfasts and lunches, or use leftover oatmeal mixed with nuts or chocolate chips to make healthy cookie bars; spoon oatmeal and mixins onto a baking sheet and cook at 300 degrees until lightly browned, for approx. 10 minutes."
                        },
                        new
                        {
                            RecipeId = 5,
                            BaseServings = 6,
                            CostPerServing = 1.36m,
                            Directions = "1) Add ground beef and chili seasoning/chili powder to a large skillet and cook medium-high until browned. 2) Add diced onion, bell pepper, and garlic, cooking over medium heat and stirring regularly until onion is translucent. 3) Add diced tomatoes(drained), green chiles(drained), and beans (undrained), return to a boil, and reduce heat to medium-low. Simmer for 20 minutes, stirring occasionally. 4) Season with salt and pepper to taste and serve(optional: try with additional spices, like cumin, oregano, mix in a dash of brown sugar or hot sauce, or top with sour cream and shredded cheese).",
                            NutritionInfo = "25g of protein per serving. About 10 grams of fiber per serving. Very high in iron and calcium.",
                            PrepTime = "Prep: 10 min. Total: 40 min. ",
                            RecipeName = "Beef Chili",
                            RecipePhoto = "https://imgur.com/a/9J4Wc8A",
                            RecipeTips = "Leftover chili can be stored in the refrigerator for up to five days can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop."
                        },
                        new
                        {
                            RecipeId = 6,
                            BaseServings = 8,
                            CostPerServing = 1.44m,
                            Directions = "Note: you will need cooking oil for this recipe. 1) Wash potato, poke a few holes in skin with a fork, and microwave for 3-5 minutes. After allowing to cool slightly, roughly chop potato. 2) Meanwhile, add ground pork to a large preheated skillet and cook on medium heat until cooked through (note: if you are using precooked breakfast sausage, wait to add sausage until the next step). 3) Add a splash of oil and full package of sliced mushrooms to skillet and continue to cook on medium-high until pork is browned and mushrooms have started to soften. 4) In a large bowl, beat eggs, a dash of salt and pepper, and any additional desired spices with a whisk or fork until frothy. 5) Pour eggs into skillet, mixing in chopped potato, spinach (lightly shred if leaves are large), and lightly sprinkle with shredded cheese (optional: add a splash of milk for fluffier consistency). Mix ingredients quickly to distribute and then Cook for 2 minutes on medium high; if using a small burner, slide skillet occasionally to ensure even cooking along the bottom of the pan. 6) Reduce to medium-low heat, cover, and cook for 15-20 minutes, or until eggs have set. 7) After cooling slightly, cut into 8 even wedges.",
                            NutritionInfo = "Approx. 20g of protein per serving. High in iron, potassium, and calcium.",
                            PrepTime = "Prep: 15 min. Total: 35 min. ",
                            RecipeName = "Sausage, Mushroom, and Spinach Frittata",
                            RecipePhoto = "https://imgur.com/a/kmKdWV0",
                            RecipeTips = "Leftover fritatta can be stored in the refrigerator for 3 days or frozen in ziplock bags. Individually wrap leftover slices for lunch and eat warm or cold."
                        });
                });

            modelBuilder.Entity("FoodSaverApi.Models.IngredientRecipe", b =>
                {
                    b.HasOne("FoodSaverApi.Models.Ingredient", "Ingredient")
                        .WithMany("Recipes")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FoodSaverApi.Models.Recipe", "Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
