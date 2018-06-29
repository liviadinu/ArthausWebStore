using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArthausWebStore.Migrations
{
    public partial class ItemVariant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {




            migrationBuilder.CreateTable(
                name: "ItemVariants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemNo = table.Column<string>(nullable: true),
                    ItemDescription = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Material = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemVariants", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemVariants");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "Item Attributes",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Item Picture",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    Picture = table.Column<byte[]>(type: "image", nullable: false),
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    WebsiteNo_ = table.Column<string>(name: "Website No_", maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Picture", x => x.ID);
                });
        }
    }
}
