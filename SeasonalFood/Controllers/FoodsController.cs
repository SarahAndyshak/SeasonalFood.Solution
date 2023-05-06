using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeasonalFood.Models;

namespace SeasonalFood.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  
  public class FoodsController : ControllerBase
  {
    private readonly SeasonalFoodContext _db;

    public FoodsController(SeasonalFoodContext db)
    {
      _db = db;
    }

    // GET api/foods
    [HttpGet]
    public async Task<List<Food>> Get(string name, string harvestSeason, string geography, string popularUses, string sampleRecipe)
    {
      IQueryable<Food> query = _db.Foods.AsQueryable();

      if(name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if(harvestSeason != null)
      {
        query = query.Where(entry => entry.HarvestSeason == harvestSeason);
      }

      if(geography != null)
      {
        query = query.Where(entry => entry.Geography == geography);
      }

      if(popularUses != null)
      {
        query = query.Where(entry => entry.PopularUses == popularUses);
      }

      if(sampleRecipe != null)
      {
        query = query.Where(entry => entry.SampleRecipe == sampleRecipe);
      }

      return await query.ToListAsync();
    }

    // GET api/foods/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Food>> GetFood(int id)
    {
      Food food = await _db.Foods.FindAsync(id);

      if(food == null)
      {
        return NotFound();
      }
      return food;
    }

    // POST api/foods
    [HttpPost]
    public async Task<ActionResult<Food>> Post(Food food)
    {
      _db.Foods.Add(food);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetFood), new { id = food.FoodId }, food);
    }

    // PUT api/foods/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Food food)
    {
      if (id != food.FoodId)
      {
        return BadRequest();
      }
      _db.Foods.Update(food);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!FoodExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    private bool FoodExists(int id)
    {
      return _db.Foods.Any(e => e.FoodId == id);
    }

    // DELETE api/foods/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteFood(int id)
    {
      Food food = await _db.Foods.FindAsync(id);
      if (food == null)
      {
        return NotFound();
      }

      _db.Foods.Remove(food);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}