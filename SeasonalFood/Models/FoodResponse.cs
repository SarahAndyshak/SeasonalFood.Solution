using SeasonalFood.Models;

namespace SeasonalFood
{
  public class FoodResponse
  {
    public List<Food> Foods { get; set; } = new List<Food>();
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
  }
}