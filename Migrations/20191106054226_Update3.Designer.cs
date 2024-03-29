﻿// <auto-generated />
using FoodSaverApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodSaverAPI.Migrations
{
    [DbContext(typeof(FoodSaverApiContext))]
    [Migration("20191106054226_Update3")]
    partial class Update3
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
                            IngredientSubstitution = "jar tomato-basil/marinara pasta sauce"
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
                            IngredientQuantity = 4,
                            IngredientSubstitution = "garlic powder, italian seasoning"
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
                            IngredientPrice = 0.75m,
                            IngredientQuantity = 1,
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
                            IngredientName = "7-9oz box white cheddar macaroni and cheese",
                            IngredientPrice = 0.75m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "any 7-9oz boxed macaroni and cheese"
                        },
                        new
                        {
                            IngredientId = 10,
                            IngredientName = "5oz can chunk light tuna in water",
                            IngredientPrice = 0.75m,
                            IngredientQuantity = 1,
                            IngredientSubstitution = "5oz can tuna of any variety"
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
                        });
                });

            modelBuilder.Entity("FoodSaverApi.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Directions");

                    b.Property<string>("NutritionInfo");

                    b.Property<string>("PrepTime");

                    b.Property<decimal>("PricePerServing");

                    b.Property<string>("RecipeName");

                    b.Property<string>("RecipeTips");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            Directions = "1) Combine ground beef, onion, and garlic in a large skillet on medium heat. Stir regularly until meat is brown and vegetables are tender. 2) Stir diced tomatoes and tomato sauce into the pan. Season with salt and pepper (optional: add 1-2 teaspoons of italian seasoning, basil, or oregano) and simmer on low 3) Simmer for 1 hour on low heat, stirring occasionally. 2) With 20 minues left, bring a large pot of water to boil and cook pasta according to box instructions. 3) Drain excess liquid from saucepan, strain pasta, and serve.",
                            NutritionInfo = "Over 20 grams of protein per serving. 10 grams of fiber per serving. Less than 10g of sugar per serving.",
                            PrepTime = "Prep: 15 min Total: 1 hour and 15 min",
                            PricePerServing = 1.00m,
                            RecipeName = "Spaghetti and Beef Marinara",
                            RecipeTips = "Refrigerate leftover sauce and pasta in separate containers for better flavor. Leftover sauce can be frozen for upwards of 2 months in sealed ziploc bags and reheated from frozen on the stovetop."
                        },
                        new
                        {
                            RecipeId = 2,
                            Directions = "1) Steam bagged brocolli in microwave or in a covered pot with a steamer on the stovetop until tender. 2) Open and strain excess liquid from tuna 2) Boil macaroni according to package instructions 3) Strain macaroni and combine with steamed brocolli, cheesepacket, extra cheddar cheese, milk, and tuna. 4) Return macaroni with mixins to the microwave or pot on stovetop and heat on low until cheese is completely melted (optional: add cheese on top of mixture of other ingredients in a casserole pan and bake at 300 degrees until cheese is slightly browned). 5) Season with salt and pepper to taste (optional: try with creole seasoning or lemon pepper ",
                            NutritionInfo = " ",
                            PrepTime = "Prep: 5 min Total: 20 min",
                            PricePerServing = 2.25m,
                            RecipeName = "Speedy Mac n' Cheese Tuna Casserole",
                            RecipeTips = " "
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
