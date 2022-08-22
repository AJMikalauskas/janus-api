using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Janus_API.Migrations
{
    public partial class added_relationship_of_assets_to_transactions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssetId",
                table: "Transactions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_AssetId",
                table: "Transactions",
                column: "AssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Assets_AssetId",
                table: "Transactions",
                column: "AssetId",
                principalTable: "Assets",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Assets_AssetId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_AssetId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "AssetId",
                table: "Transactions");
        }
    }
}
