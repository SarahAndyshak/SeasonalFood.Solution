namespace SeasonalFood.Models
{
  public class Food
  {
    public int FoodId { get; set; }
    public string Name { get; set; }
    public string HarvestSeason { get; set; }
    public string Geography { get; set; }
    public string PopularUses { get; set; }
    public string SampleRecipe { get; set; }
  }
}