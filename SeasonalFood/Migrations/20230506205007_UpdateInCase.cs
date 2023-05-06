using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeasonalFood.Migrations
{
    public partial class UpdateInCase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parks",
                table: "Parks");

            migrationBuilder.RenameTable(
                name: "Parks",
                newName: "Foods");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Foods",
                table: "Foods",
                column: "FoodId");

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 1,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Northern hemisphere, East Asia, Australia.", "Spring and early summer.", "Eaten raw, baked into pies and cakes, jams, jellies, sauces, dried for later use" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 2,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Today tomatoes are grown around the world.", "Mid to late summer.", "Eaten raw, in salads, processed into sauces, pastes and ketchup, made into salsas, soups, juice, cocktails, stewed, breaded, and fried." });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 3,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Today carrots are grown around the world.", "If planted in early spring, harvest in early summer. If planted in late summer, harvest in fall or early winter.", "Eaten raw, in salads, boiled, fried, steamed, made into soups and broths, baked into carrot cake, made into jams and preserves, dehydrated to turn into fried chips." });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 4,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Tropical and subtropical climates.", "Oranges may be harvested at various times during the year; in the United States navel oranges may be harvested in cooler months.", "Eaten raw, made into juice, candied, the skin can be zested, made into jam, marmalade, and preserves, processed into oils" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 5,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Tropical and subtropical climates.", "Late summer through winter.", "Eaten raw, incorporated into desserts, added to many savory foods, used in salsas, made into lassi, processed into chutney." });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 6,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Tropical regions.", "Late spring and early summer.", "Eaten raw, made into banana bread, pancakes, and muffins, made into shakes and smoothies, incorporated into many desserts." });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 7,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Native to the tropics, but varieties can be grown around the world.", "Early autumn.", "Eaten raw, added into desserts and baked goods, added to salads" });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 8,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Tropical and sub-tropical regions.", "Avocados are in season all year in Mexico.", "Eaten in salads, made into guacamole, eaten on toast, made into smoothies, made into soups, used in sushi, juiced, incorporated into drinks and ice creams." });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "FoodId",
                keyValue: 9,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "Cooler regions.", "Spring and early summer.", "Eaten raw, added to salads, steamed, stir-fried" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Foods",
                table: "Foods");

            migrationBuilder.RenameTable(
                name: "Foods",
                newName: "Parks");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parks",
                table: "Parks",
                column: "FoodId");

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 1,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 2,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 3,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 4,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 5,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 6,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 7,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 8,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Parks",
                keyColumn: "FoodId",
                keyValue: 9,
                columns: new[] { "Geography", "HarvestSeason", "PopularUses" },
                values: new object[] { "", "", "" });
        }
    }
}
