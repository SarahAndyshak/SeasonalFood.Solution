using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeasonalFood.Migrations
{
    public partial class AddInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HarvestSeason = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Geography = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PopularUses = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SampleRecipe = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.FoodId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "FoodId", "Geography", "HarvestSeason", "Name", "PopularUses", "SampleRecipe" },
                values: new object[,]
                {
                    { 1, "", "", "Cherry", "", "" },
                    { 2, "", "", "Tomato", "", "" },
                    { 3, "", "", "Carrot", "", "" },
                    { 4, "", "", "Orange", "", "" },
                    { 5, "", "", "Mango", "", "" },
                    { 6, "", "", "Banana", "", "" },
                    { 7, "", "", "Kiwi", "", "" },
                    { 8, "", "", "Avocado", "", "" },
                    { 9, "", "", "Broccoli", "", "" },
                    { 10, "", "", "Cauliflower", "", "" },
                    { 11, "", "", "Blueberries", "", "" },
                    { 12, "", "", "Cabbage", "", "" },
                    { 13, "", "", "Grapes", "", "" },
                    { 14, "", "", "Dragonfruit", "", "" },
                    { 15, "", "", "Watermelon", "", "" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
