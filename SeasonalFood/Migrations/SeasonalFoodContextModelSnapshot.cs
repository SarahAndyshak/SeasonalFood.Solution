﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeasonalFood.Models;

#nullable disable

namespace SeasonalFood.Migrations
{
    [DbContext(typeof(SeasonalFoodContext))]
    partial class SeasonalFoodContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SeasonalFood.Models.Food", b =>
                {
                    b.Property<int>("FoodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Geography")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("HarvestSeason")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PopularUses")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SampleRecipe")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("FoodId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            FoodId = 1,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Cherry",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 2,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Tomato",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 3,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Carrot",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 4,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Orange",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 5,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Mango",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 6,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Banana",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 7,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Kiwi",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 8,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Avocado",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 9,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Broccoli",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 10,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Cauliflower",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 11,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Blueberries",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 12,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Cabbage",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 13,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Grapes",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 14,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Dragonfruit",
                            PopularUses = "",
                            SampleRecipe = ""
                        },
                        new
                        {
                            FoodId = 15,
                            Geography = "",
                            HarvestSeason = "",
                            Name = "Watermelon",
                            PopularUses = "",
                            SampleRecipe = ""
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
