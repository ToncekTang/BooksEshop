using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eshop.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addProductsToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    PriceFifty = table.Column<double>(type: "float", nullable: false),
                    PriceHundred = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "PriceFifty", "PriceHundred", "Title" },
                values: new object[,]
                {
                    { 1, "Tianqi Tang1", "Praesent vitae sodales libero. Praesent molestie orci augue, vitae euismod velit sollicitudin ac. Praesent vestibulum facilisis nibh ut ultricies.\r\n\r\nNunc malesuada viverra ipsum sit amet tincidunt. ", "TTQ0000001", 99.0, 90.0, 85.0, 80.0, "CocaCola1" },
                    { 2, "Tianqi Tang2", "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ", "TTQ0000002", 40.0, 30.0, 25.0, 20.0, "CocaCola2" },
                    { 3, "Tianqi Tang3", "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ", "TTQ0000003", 55.0, 50.0, 40.0, 35.0, "CocaCola3" },
                    { 4, "Tianqi Tang4", "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles. ", "TTQ0000004", 70.0, 65.0, 60.0, 55.0, "CocaCola4" },
                    { 5, "Tianqi Tang5", "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles.  ", "TTQ0000005", 30.0, 27.0, 25.0, 20.0, "CocaCola5" },
                    { 6, "Tianqi Tang6", "CocaCola classic.\r\n\r\nThe Baron Crispy Corn Nibbles.  ", "TTQ0000006", 25.0, 23.0, 22.0, 20.0, "CocaCola6" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);
        }
    }
}
