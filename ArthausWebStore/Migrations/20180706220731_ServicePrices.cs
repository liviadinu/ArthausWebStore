using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArthausWebStore.Migrations
{
    public partial class ServicePrices : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Base Capacity Unit of Measure",
                table: "Service Product");

            migrationBuilder.CreateTable(
                name: "ServiceProductPrices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MyProperty = table.Column<string>(nullable: true),
                    ServiceNo = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    BaseCapacityUnitOfMeasure = table.Column<string>(nullable: true),
                    PricingMethod = table.Column<string>(nullable: true),
                    PricePerUnit = table.Column<decimal>(nullable: false),
                    MinAmountToOrder = table.Column<decimal>(nullable: false),
                    FreeAfterPoint = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceProductPrices", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceProductPrices");

            migrationBuilder.AddColumn<string>(
                name: "Base Capacity Unit of Measure",
                table: "Service Product",
                maxLength: 10,
                nullable: false,
                defaultValue: "");
        }
    }
}
