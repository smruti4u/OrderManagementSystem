using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Domain.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "resturant",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resturant", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "menu",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    resturantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_menu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_menu_resturant_resturantId",
                        column: x => x.resturantId,
                        principalTable: "resturant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "oreder",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    resturantId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_oreder", x => x.Id);
                    table.ForeignKey(
                        name: "FK_oreder_resturant_resturantId",
                        column: x => x.resturantId,
                        principalTable: "resturant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_menu_resturantId",
                table: "menu",
                column: "resturantId");

            migrationBuilder.CreateIndex(
                name: "IX_oreder_resturantId",
                table: "oreder",
                column: "resturantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "menu");

            migrationBuilder.DropTable(
                name: "oreder");

            migrationBuilder.DropTable(
                name: "resturant");
        }
    }
}
