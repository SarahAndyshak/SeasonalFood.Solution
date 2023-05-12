using Microsoft.EntityFrameworkCore;

namespace SeasonalFood.Models
{
  public class SeasonalFoodContext : DbContext
  {
    public DbSet<Food> Foods { get; set; }

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
            SampleRecipe = "Quick and Easy Fresh Cherry Pie, by David Martin | cookeatshare.com | https://cookeatshare.com/recipes/quick-and-easy-fresh-cherry-pie-692039" },
          
          new Food { FoodId = 2, 
          Name = "Tomato", 
          HarvestSeason = "Mid to late summer.", 
          Geography = "Today tomatoes are grown around the world.", 
          PopularUses = "Eaten raw, in salads, processed into sauces, pastes and ketchup, made into salsas, soups, juice, cocktails, stewed, breaded, and fried.", 
          SampleRecipe = "Mediterranean Lamb Stew with tomato, mushroom and eggplant (Kokkinisto), by John Spottiswood | cookeatshare.com |https://cookeatshare.com/recipes/mediterranean-lamb-stew-with-tomato-mushroom-and-eggplant-kokkinisto-797643" },
          
          new Food { FoodId = 3, 
          Name = "Carrot", 
          HarvestSeason = "If planted in early spring, harvest in early summer. If planted in late summer, harvest in fall or early winter.", 
          Geography = "Today carrots are grown around the world.", 
          PopularUses = "Eaten raw, in salads, boiled, fried, steamed, made into soups and broths, baked into carrot cake, made into jams and preserves, dehydrated to turn into fried chips.", 
          SampleRecipe = "Carrot and Red Lentil Soup, by Easy Cook - Laka kuharica | cookeatshare.com | https://cookeatshare.com/recipes/carrot-and-red-lentils-soup-761174" },
          
          new Food { FoodId = 4, 
          Name = "Orange", 
          HarvestSeason = "Oranges may be harvested at various times during the year; in the United States navel oranges may be harvested in cooler months (fall, winter).", 
          Geography = "Tropical and subtropical climates.", 
          PopularUses = "Eaten raw, made into juice, candied, the skin can be zested, made into jam, marmalade, and preserves, processed into oils", 
          SampleRecipe = "Smoked Orange Peel Chicken, by Patti Fisher | cookeatshare.com | https://cookeatshare.com/recipes/smoked-orange-peel-chicken-793501" },

          new Food { FoodId = 5, 
          Name = "Mango", 
          HarvestSeason = "Late summer, fall, and winter.", 
          Geography = "Tropical and subtropical climates.", 
          PopularUses = "Eaten raw, incorporated into desserts, added to many savory foods, used in salsas, made into lassi, processed into chutney.", 
          SampleRecipe = "Mango Lassi, by pshinde2109 | cookeatshare.com | https://cookeatshare.com/recipes/mango-lassi-743042" },

          new Food { FoodId = 6, 
          Name = "Banana", 
          HarvestSeason = "Late spring and early summer.", 
          Geography = "Tropical regions.",
          PopularUses = "Eaten raw, made into banana bread, pancakes, and muffins, made into shakes and smoothies, incorporated into many desserts.", 
          SampleRecipe = "Easy Banana Bread, by ShaleeDP | cookeatshare.com | https://cookeatshare.com/recipes/easy-banana-bread-719687" },

          new Food { FoodId = 7, 
          Name = "Kiwi", 
          HarvestSeason = "Early fall.", 
          Geography = "Native to the tropics, but varieties can be grown around the world.", 
          PopularUses = "Eaten raw, added into desserts and baked goods, added to salads", 
          SampleRecipe = "Chocolate Kiwi Smoothie, by Nupur UKrasoi | cookeatshare.com | https://cookeatshare.com/recipes/chocolate-kiwi-smoothie-700004" },

          new Food { FoodId = 8, 
          Name = "Avocado", 
          HarvestSeason = "Avocados are in season all year in Mexico (spring, summer, winter, and fall).", 
          Geography = "Tropical and sub-tropical regions.", 
          PopularUses = "Eaten in salads, made into guacamole, eaten on toast, made into smoothies, made into soups, used in sushi, juiced, incorporated into drinks and ice creams.", 
          SampleRecipe = "Quinoa Salad with Broccoli and Chickpeas, by Ronda | cookeatshare.com | https://cookeatshare.com/recipes/quinoa-salad-with-broccoli-and-chickpeas-707082" },

          new Food { FoodId = 9, 
          Name = "Broccoli", 
          HarvestSeason = "Spring and early summer.", 
          Geography = "Cooler regions.", 
          PopularUses = "Eaten raw, added to salads, steamed, stir-fried.", 
          SampleRecipe = "" },

          new Food { FoodId = 10, 
          Name = "Cauliflower", 
          HarvestSeason = "Early fall and spring.", 
          Geography = "Cool-weather climates.", 
          PopularUses = "Eaten raw, roasted, grilled, steamed, pickled, made into pizza crust, mashed like potatoes.", 
          SampleRecipe = "Gobi (Cauliflower) Manchurian, by Hina Gujral | cookeatshare.com | https://cookeatshare.com/recipes/gobi-cauliflower-manchurian-772137" },

          new Food { FoodId = 11, 
          Name = "Blueberries", 
          HarvestSeason = "Spring and summer.", 
          Geography = "Humid northern climates, coastal regions.", 
          PopularUses = "Eaten raw, added to fruit salads, made into jellies and jams, pureed, baked into muffins, pancakes, pies, fermented for wine.", 
          SampleRecipe = "Banana Blueberry Muffin, by Simmy Routroy | cookeatshare.com | https://cookeatshare.com/recipes/banana-blueberry-muffin-810851" },

          new Food { FoodId = 12, 
          Name = "Cabbage", 
          HarvestSeason = "Late summer to late fall.", 
          Geography = "World-wide, areas with cool temperatures and moisture.", 
          PopularUses = "Eaten raw, steamed, pickled, stewed, sauteed, made into soups, sourkraut, kimchi, in stuffed cabbage dishes, and dumplings.", 
          SampleRecipe = "Stuffed Cabbage (Golabki), by Therese | cookeatshare.com | https://cookeatshare.com/recipes/stuffed-cabbage-golabki-664567" },

          new Food { FoodId = 13, 
          Name = "Grapes", 
          HarvestSeason = "Early fall.", 
          Geography = "Areas with milder climates.", 
          PopularUses = "Eaten raw, added to fruit salads, made into jellies and jams, dried into raisins, made into juice, fermented for wine.", 
          SampleRecipe = "Fresh and Easy Grape Sherbet, by Catherine Pappas | cookeatshare.com | https://cookeatshare.com/recipes/fresh-and-easy-grape-sherbet-686486" },

          new Food { FoodId = 14, 
          Name = "Dragon fruit", 
          HarvestSeason = "Summer.", 
          Geography = "Tropical regions.", 
          PopularUses = "Eaten raw, used for juices and teas.", 
          SampleRecipe = "No Bake Dessert | Tropical Coconut Milk Rice Pudding … with dragon fruit & rambutans, by Deeba Rajpal | cookeatshare.com | https://cookeatshare.com/recipes/no-bake-dessert-tropical-coconut-milk-rice-pudding-with-dragon-fruit-rambutans-719670/external"},

          new Food { FoodId = 15, 
          Name = "Watermelon", 
          HarvestSeason = "Summer.", 
          Geography = "Tropical to temperate climates.", 
          PopularUses = "Eaten raw, added to fruit salads, made into juice and wine.", 
          SampleRecipe = "Watermelon Salsa, by Kelsey Martin | cookeatshare.com | https://cookeatshare.com/recipes/watermelon-salsa-587" }         
        );
    }
  }
}