using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClkEmlak.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class first_migration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    EstateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CoverPhoto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GrossSquareMeters = table.Column<int>(type: "int", nullable: false),
                    NetSquareMeters = table.Column<int>(type: "int", nullable: false),
                    Rooms = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingAge = table.Column<int>(type: "int", nullable: false),
                    NumberOfFloors = table.Column<int>(type: "int", nullable: false),
                    FloorLocation = table.Column<int>(type: "int", nullable: false),
                    Heating = table.Column<int>(type: "int", nullable: false),
                    BathNumber = table.Column<int>(type: "int", nullable: false),
                    Balcony = table.Column<bool>(type: "bit", nullable: false),
                    Lift = table.Column<bool>(type: "bit", nullable: false),
                    CarPark = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    HomePage = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.EstateID);
                    table.ForeignKey(
                        name: "FK_Estates_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estates_CategoryID",
                table: "Estates",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estates");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
