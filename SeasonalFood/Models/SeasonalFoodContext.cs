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
            HarvestSeason = "Spring and early summer.", 
            Geography = "Northern hemisphere, East Asia, Australia.", 
            PopularUses = "Eaten raw, baked into pies and cakes, jams, jellies, sauces, dried for later use", 
            SampleRecipe = "" },
          
          new Food { FoodId = 2, 
          Name = "Tomato", 
          HarvestSeason = "Mid to late summer.", 
          Geography = "Today tomatoes are grown around the world.", 
          PopularUses = "Eaten raw, in salads, processed into sauces, pastes and ketchup, made into salsas, soups, juice, cocktails, stewed, breaded, and fried.", 
          SampleRecipe = "" },
          
          new Food { FoodId = 3, 
          Name = "Carrot", 
          HarvestSeason = "If planted in early spring, harvest in early summer. If planted in late summer, harvest in fall or early winter.", 
          Geography = "Today carrots are grown around the world.", 
          PopularUses = "Eaten raw, in salads, boiled, fried, steamed, made into soups and broths, baked into carrot cake, made into jams and preserves, dehydrated to turn into fried chips.", 
          SampleRecipe = "" },
          
          new Food { FoodId = 4, 
          Name = "Orange", 
          HarvestSeason = "Oranges may be harvested at various times during the year; in the United States navel oranges may be harvested in cooler months.", 
          Geography = "Tropical and subtropical climates.", 
          PopularUses = "Eaten raw, made into juice, candied, the skin can be zested, made into jam, marmalade, and preserves, processed into oils", 
          SampleRecipe = "" },

          new Food { FoodId = 5, 
          Name = "Mango", 
          HarvestSeason = "Late summer through winter.", 
          Geography = "Tropical and subtropical climates.", 
          PopularUses = "Eaten raw, incorporated into desserts, added to many savory foods, used in salsas, made into lassi, processed into chutney.", 
          SampleRecipe = "" },

          new Food { FoodId = 6, 
          Name = "Banana", 
          HarvestSeason = "Late spring and early summer.", 
          Geography = "Tropical regions.",
          PopularUses = "Eaten raw, made into banana bread, pancakes, and muffins, made into shakes and smoothies, incorporated into many desserts.", 
          SampleRecipe = "" },

          new Food { FoodId = 7, 
          Name = "Kiwi", 
          HarvestSeason = "Early autumn.", 
          Geography = "Native to the tropics, but varieties can be grown around the world.", 
          PopularUses = "Eaten raw, added into desserts and baked goods, added to salads", 
          SampleRecipe = "" },

          new Food { FoodId = 8, 
          Name = "Avocado", 
          HarvestSeason = "Avocados are in season all year in Mexico.", 
          Geography = "Tropical and sub-tropical regions.", 
          PopularUses = "Eaten in salads, made into guacamole, eaten on toast, made into smoothies, made into soups, used in sushi, juiced, incorporated into drinks and ice creams.", 
          SampleRecipe = "" },

          new Food { FoodId = 9, 
          Name = "Broccoli", 
          HarvestSeason = "Spring and early summer.", 
          Geography = "Cooler regions.", 
          PopularUses = "Eaten raw, added to salads, steamed, stir fried.", 
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