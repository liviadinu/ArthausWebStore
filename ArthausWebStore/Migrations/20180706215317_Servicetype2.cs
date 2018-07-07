using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArthausWebStore.Migrations
{
    public partial class Servicetype2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service Price Group");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service Price Group",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    FreeAfterAmtPoint = table.Column<decimal>(nullable: false),
                    MinUnitsOrder = table.Column<int>(nullable: false),
                    PricePerUnit = table.Column<decimal>(nullable: false),
                    PricingMethod = table.Column<string>(nullable: true),
                    ServiceNo = table.Column<string>(nullable: true),
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Price Group", x => x.Code);
                });

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Price Group",
                columns: new[] { "Description", "Code" },
                unique: true);
        }
    }
}
