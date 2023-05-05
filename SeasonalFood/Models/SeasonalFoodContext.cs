using Microsoft.EntityFrameworkCore;

namespace SeasonalFood.Models
{
  public class SeasonalFoodContext : DbContext
  {
    public DbSet<Food> Parks { get; set; }

    public SeasonalFoodContext(DbContextOptions<SeasonalFoodContext>options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Food>()
        .HasData(
          new Food { FoodId = 1, 
            Name = "Cherry", 
            HarvestSeason = "", 
            Geography = "", 
            PopularUses = "", 
            SampleRecipe = "" },
          
          new Food { FoodId = 2, 
          Name = "Tomato", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },
          
          new Food { FoodId = 3, 
          Name = "Carrot", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },
          
          new Food { FoodId = 4, 
          Name = "Orange", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 5, 
          Name = "Mango", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 6, 
          Name = "Banana", 
          HarvestSeason = "", 
          Geography = "",
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 7, 
          Name = "Kiwi", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 8, 
          Name = "Avocado", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 9, 
          Name = "Broccoli", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 10, 
          Name = "Cauliflower", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 11, 
          Name = "Blueberries", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 12, 
          Name = "Cabbage", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 13, 
          Name = "Grapes", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 14, 
          Name = "Dragonfruit", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" },

          new Food { FoodId = 15, 
          Name = "Watermelon", 
          HarvestSeason = "", 
          Geography = "", 
          PopularUses = "", 
          SampleRecipe = "" }         
        );
    }
  }
}