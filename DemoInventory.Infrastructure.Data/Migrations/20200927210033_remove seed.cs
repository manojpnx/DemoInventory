using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoInventory.Infrastructure.Data.Migrations
{
    public partial class removeseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity", "ReorderLevel", "Sku" },
                values: new object[] { 10L, "Apple iPhone X", "iPhone X", 1000m, 500, 10, "P-000001" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity", "ReorderLevel", "Sku" },
                values: new object[] { 11L, "Google Pixel 4", "Pixel 4", 900m, 400, 20, "P-000002" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Quantity", "ReorderLevel", "Sku" },
                values: new object[] { 12L, "SAmsung Galaxy A30", "Galaxy A30", 700m, 800, 30, "P-000003" });
        }
    }
}
