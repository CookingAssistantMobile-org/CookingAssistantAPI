﻿// <auto-generated />
using System;
using CookingAssistantAPI.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CookingAssistantAPI.Migrations
{
    [DbContext(typeof(CookingDbContext))]
    partial class RecipeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Sqlite:ForeignKeys", true);

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IngredientName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IngredientName")
                        .IsUnique();

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Nutrient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("NutrientName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NutrientName")
                        .IsUnique();

                    b.ToTable("Nutrients");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CreatedById")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Difficulty")
                        .HasColumnType("TEXT");

                    b.Property<byte[]>("ImageData")
                        .HasColumnType("BLOB");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<float>("Ratings")
                        .HasColumnType("REAL");

                    b.Property<int>("Serves")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TimeInMinutes")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VoteCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CreatedById");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.RecipeIngredient", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IngredientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Unit")
                        .HasColumnType("TEXT");

                    b.HasKey("RecipeId", "IngredientId");

                    b.HasIndex("IngredientId");

                    b.ToTable("RecipeIngredients");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.RecipeNutrient", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NutrientId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Quantity")
                        .HasColumnType("TEXT");

                    b.Property<string>("Unit")
                        .HasColumnType("TEXT");

                    b.HasKey("RecipeId", "NutrientId");

                    b.HasIndex("NutrientId");

                    b.ToTable("RecipeNutrients");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Step", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StepNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Steps");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserFavoriteRecipe", b =>
                {
                    b.Property<int>("RecipeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecipeId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserFavoriteRecipe");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Recipe", b =>
                {
                    b.HasOne("CookingAssistantAPI.Database.Models.Category", "Category")
                        .WithMany("Recipes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookingAssistantAPI.Database.Models.User", "CreatedBy")
                        .WithMany("CreatedRecipes")
                        .HasForeignKey("CreatedById");

                    b.Navigation("Category");

                    b.Navigation("CreatedBy");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.RecipeIngredient", b =>
                {
                    b.HasOne("CookingAssistantAPI.Database.Models.Ingredient", "Ingredient")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("IngredientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookingAssistantAPI.Database.Models.Recipe", "Recipe")
                        .WithMany("RecipeIngredients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingredient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.RecipeNutrient", b =>
                {
                    b.HasOne("CookingAssistantAPI.Database.Models.Nutrient", "Nutrient")
                        .WithMany("RecipeNutrients")
                        .HasForeignKey("NutrientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookingAssistantAPI.Database.Models.Recipe", "Recipe")
                        .WithMany("RecipeNutrients")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nutrient");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Step", b =>
                {
                    b.HasOne("CookingAssistantAPI.Database.Models.Recipe", "Recipe")
                        .WithMany("Steps")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.User", b =>
                {
                    b.HasOne("CookingAssistantAPI.Database.Models.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("UserFavoriteRecipe", b =>
                {
                    b.HasOne("CookingAssistantAPI.Database.Models.Recipe", null)
                        .WithMany()
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CookingAssistantAPI.Database.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Category", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Ingredient", b =>
                {
                    b.Navigation("RecipeIngredients");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Nutrient", b =>
                {
                    b.Navigation("RecipeNutrients");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.Recipe", b =>
                {
                    b.Navigation("RecipeIngredients");

                    b.Navigation("RecipeNutrients");

                    b.Navigation("Steps");
                });

            modelBuilder.Entity("CookingAssistantAPI.Database.Models.User", b =>
                {
                    b.Navigation("CreatedRecipes");
                });
#pragma warning restore 612, 618
        }
    }
}
