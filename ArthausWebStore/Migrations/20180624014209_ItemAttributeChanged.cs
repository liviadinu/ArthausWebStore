using Microsoft.EntityFrameworkCore.Migrations;

namespace ArthausWebStore.Migrations
{
    public partial class ItemAttributeChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "BestSeller",
                table: "Item Attributes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Featured",
                table: "Item Attributes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MostViewed",
                table: "Item Attributes",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BestSeller",
                table: "Item Attributes");

            migrationBuilder.DropColumn(
                name: "Featured",
                table: "Item Attributes");

            migrationBuilder.DropColumn(
                name: "MostViewed",
                table: "Item Attributes");
        }
    }
}
