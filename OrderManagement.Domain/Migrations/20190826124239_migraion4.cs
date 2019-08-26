using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderManagement.Domain.Migrations
{
    public partial class migraion4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_oreder_resturant_resturantId",
                table: "oreder");

            migrationBuilder.DropPrimaryKey(
                name: "PK_oreder",
                table: "oreder");

            migrationBuilder.RenameTable(
                name: "oreder",
                newName: "order");

            migrationBuilder.RenameIndex(
                name: "IX_oreder_resturantId",
                table: "order",
                newName: "IX_order_resturantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_order",
                table: "order",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_order_resturant_resturantId",
                table: "order",
                column: "resturantId",
                principalTable: "resturant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_order_resturant_resturantId",
                table: "order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_order",
                table: "order");

            migrationBuilder.RenameTable(
                name: "order",
                newName: "oreder");

            migrationBuilder.RenameIndex(
                name: "IX_order_resturantId",
                table: "oreder",
                newName: "IX_oreder_resturantId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_oreder",
                table: "oreder",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_oreder_resturant_resturantId",
                table: "oreder",
                column: "resturantId",
                principalTable: "resturant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
