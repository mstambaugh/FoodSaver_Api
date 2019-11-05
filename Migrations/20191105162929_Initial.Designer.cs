﻿// <auto-generated />
using FoodSaverApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodSaverAPI.Migrations
{
    [DbContext(typeof(FoodSaverApiContext))]
    [Migration("20191105162929_Initial")]
    partial class Initial
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

                    b.Property<string>("IngredientSubstitution");

                    b.HasKey("IngredientId");

                    b.ToTable("Ingredients");

                    b.HasData(
                        new
                        {
                            IngredientId = 1,
                            IngredientName = "1 lb wheat spaghetti",
                            IngredientPrice = 1.20m,
                            IngredientSubstitution = "1 lb wheat pasta any shape"
                        },
                        new
                        {
                            IngredientId = 2,
                            IngredientName = "large can tomatoes",
                            IngredientPrice = 1.10m,
                            IngredientSubstitution = "large can tomato sauce"
                        },
                        new
                        {
                            IngredientId = 3,
                            IngredientName = "1/2 medium onion",
                            IngredientPrice = 0.70m,
                            IngredientSubstitution = "onion powder"
                        },
                        new
                        {
                            IngredientId = 4,
                            IngredientName = "garlic powder",
                            IngredientPrice = 1.50m,
                            IngredientSubstitution = "italian seasoning"
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
                        });
                });

            modelBuilder.Entity("FoodSaverApi.Models.Recipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Directions");

                    b.Property<string>("NutritionInfo");

                    b.Property<string>("RecipeName");

                    b.Property<string>("RecipeTips");

                    b.HasKey("RecipeId");

                    b.ToTable("Recipes");

                    b.HasData(
                        new
                        {
                            RecipeId = 1,
                            Directions = "do this, this, and this. How to store leftovers.",
                            NutritionInfo = "fiber, vitamins, minerals, hella flavor ",
                            RecipeName = "Spaghetti and Marinara",
                            RecipeTips = "save the leftover half of your onion for other crap. How to store info. What you can add if you have it."
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