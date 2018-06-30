using Microsoft.EntityFrameworkCore.Migrations;

namespace ArthausWebStore.Migrations
{
    public partial class ErroLog2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Exception",
                table: "ErrorLog",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Exception",
                table: "ErrorLog");
        }
    }
}
