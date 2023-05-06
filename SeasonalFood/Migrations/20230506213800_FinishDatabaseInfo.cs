using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeasonalFood.Migrations
{
    public partial class FinishDatabaseInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "SampleRecipe",
                value: "Quick and Easy Fresh Cherry Pie, by David Martin | cookeatshare.com | https://cookeatshare.com/recipes/quick-and-easy-fresh-cherry-pie-692039");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "SampleRecipe",
                value: "Mediterranean Lamb Stew with tomato, mushroom and eggplant (Kokkinisto), by John Spottiswood | cookeatshare.com |https://cookeatshare.com/recipes/mediterranean-lamb-stew-with-tomato-mushroom-and-eggplant-kokkinisto-797643");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "SampleRecipe",
                value: "Carrot and Red Lentil Soup, by Easy Cook - Laka kuharica | cookeatshare.com | https://cookeatshare.com/recipes/carrot-and-red-lentils-soup-761174");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "SampleRecipe",
                value: "Smoked Orange Peel Chicken, by Patti Fisher | cookeatshare.com | https://cookeatshare.com/recipes/smoked-orange-peel-chicken-793501");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "SampleRecipe",
                value: "Mango Lassi, by pshinde2109 | cookeatshare.com | https://cookeatshare.com/recipes/mango-lassi-743042");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                column: "SampleRecipe",
                value: "Easy Banana Bread, by ShaleeDP | cookeatshare.com | https://cookeatshare.com/recipes/easy-banana-bread-719687");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "SampleRecipe",
                value: "Chocolate Kiwi Smoothie, by Nupur UKrasoi | cookeatshare.com | https://cookeatshare.com/recipes/chocolate-kiwi-smoothie-700004");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                column: "SampleRecipe",
                value: "Quinoa Salad with Broccoli and Chickpeas, by Ronda | cookeatshare.com | https://cookeatshare.com/recipes/quinoa-salad-with-broccoli-and-chickpeas-707082");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9,
                column: "PopularUses",
                value: "Eaten raw, added to salads, steamed, stir-fried.");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "Cool-weather climates.", "Early fall, spring.", "Eaten raw, roasted, grilled, steamed, pickled, made into pizza crust, mashed like potatoes.", "Gobi (Cauliflower) Manchurian, by Hina Gujral | cookeatshare.com | https://cookeatshare.com/recipes/gobi-cauliflower-manchurian-772137" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "Humid northern climates, coastal regions.", "Spring and summer.", "Eaten raw, added to fruit salads, made into jellies and jams, pureed, baked into muffins, pancakes, pies, fermented for wine.", "Banana Blueberry Muffin, by Simmy Routroy | cookeatshare.com | https://cookeatshare.com/recipes/banana-blueberry-muffin-810851" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "World-wide, areas with cool temperatures and moisture.", "Late summer to late fall.", "Eaten raw, steamed, pickled, stewed, sauteed, made into soups, sourkraut, kimchi, in stuffed cabbage dishes, and dumplings.", "Stuffed Cabbage (Golabki), by Therese | cookeatshare.com | https://cookeatshare.com/recipes/stuffed-cabbage-golabki-664567" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 13,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "Areas with milder climates.", "Early autumn.", "Eaten raw, added to fruit salads, made into jellies and jams, dried into raisins, made into juice, fermented for wine.", "Fresh and Easy Grape Sherbet, by Catherine Pappas | cookeatshare.com | https://cookeatshare.com/recipes/fresh-and-easy-grape-sherbet-686486" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 14,
                columns: new[] { "Geography", "HarvestSeason", "Name", "PopularUses", "SampleRecipe" },
                values: new object[] { "Tropical regions.", "Summer.", "Dragon fruit", "Eaten raw, used for juices and teas.", "No Bake Dessert | Tropical Coconut Milk Rice Pudding … with dragon fruit & rambutans, by Deeba Rajpal | cookeatshare.com | https://cookeatshare.com/recipes/no-bake-dessert-tropical-coconut-milk-rice-pudding-with-dragon-fruit-rambutans-719670/external" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 15,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "Tropical to temperate climates.", "Summer.", "Eaten raw, added to fruit salads, made into juice and wine.", "Watermelon Salsa, by Kelsey Martin | cookeatshare.com | https://cookeatshare.com/recipes/watermelon-salsa-587" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                column: "SampleRecipe",
                value: "");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9,
                column: "PopularUses",
                value: "Eaten raw, added to salads, steamed, stir-fried");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 10,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 11,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 12,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 13,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 14,
                columns: new[] { "Geography", "HarvestSeason", "Name", "PopularUses", "SampleRecipe" },
                values: new object[] { "", "", "Dragonfruit", "", "" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 15,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses", "SampleRecipe" },
                values: new object[] { "", "", "", "" });
        }
    }
}
