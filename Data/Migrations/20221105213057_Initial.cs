using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClockFace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClockFace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Watches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    img = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Material = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Guarantee = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ClockFaceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Watches_ClockFace_ClockFaceId",
                        column: x => x.ClockFaceId,
                        principalTable: "ClockFace",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClockFace",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Blue" },
                    { 2, "White" },
                    { 3, "Black" },
                    { 4, "Green" }
                });

            migrationBuilder.InsertData(
                table: "Watches",
                columns: new[] { "Id", "Brand", "ClockFaceId", "Guarantee", "Material", "Model", "Price", "img" },
                values: new object[,]
                {
                    { 1, "Rolex", 3, "3 years", "Steel 904L", "Air-King", 7400m, "/Images/Rolex Air-King.png" },
                    { 2, "Rolex", 3, "3 years", "Stainless Steel", "Datejust", 7800m, "/Images/Rolex Datejust.png" },
                    { 3, "Rolex", 3, "4 years", "18-carat Everose gold", "Yacht-Master", 47150m, "/Images/Rolex Yacht-Master.png" },
                    { 4, "Rolex", 2, "5 years", "Stainless Steel, Yellow Gold 18k", "Sea-Dweller", 23500m, "/Images/Rolex Sea-Dweller.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Watches_ClockFaceId",
                table: "Watches",
                column: "ClockFaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Watches");

            migrationBuilder.DropTable(
                name: "ClockFace");
        }
    }
}
