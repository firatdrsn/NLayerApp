using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NLayer.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", maxLength: 50, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Computers", null },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phones", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Books", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Games", null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CreatedDate", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8326), "Asus Laptop", 2000m, 15, null },
                    { 2, 1, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8343), "Lenovo Laptop", 2000m, 15, null },
                    { 3, 1, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8344), "Macbook Laptop", 2000m, 15, null },
                    { 4, 1, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8346), "Monster Gamebook", 2000m, 15, null },
                    { 5, 1, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8347), "MSI Laptop", 2000m, 15, null },
                    { 6, 2, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8348), "Samsung Galaxy", 2000m, 15, null },
                    { 7, 2, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8349), "Xiaomi RedMi", 2000m, 15, null },
                    { 8, 2, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8351), "Iphone", 2000m, 15, null },
                    { 9, 2, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8352), "Google Pixel", 2000m, 15, null },
                    { 10, 3, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8353), "The Lord Of The Rings: The Fellowship Of The Ring", 30m, 1000, null },
                    { 11, 3, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8354), "The Lord Of The Rings: The Two Towers", 30m, 1000, null },
                    { 12, 3, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8355), "The Lord Of The Rings: Return Of The King", 30m, 1000, null },
                    { 13, 4, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8357), "Red Dead Redemption", 60m, 1000, null },
                    { 14, 4, new DateTime(2022, 12, 7, 19, 23, 15, 548, DateTimeKind.Local).AddTicks(8358), "Red Dead Redemption 2", 60m, 1000, null }
                });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "Color", "Height", "ProductId", "Width" },
                values: new object[] { 1, "Red", 2, 1, 36 });

            migrationBuilder.InsertData(
                table: "ProductFeatures",
                columns: new[] { "Id", "Color", "Height", "ProductId", "Width" },
                values: new object[] { 2, "Blue", 2, 4, 42 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
