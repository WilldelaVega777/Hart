using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hart.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "CHAR(36)", nullable: false, collation: "ascii_general_ci"),
                    Description = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Count", "Description" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), 30, "Chair" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Count", "Description" },
                values: new object[] { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991871"), 10, "Table" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
