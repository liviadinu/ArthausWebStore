using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArthausWebStore.Migrations
{
    public partial class IdendtityAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "$2",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "$5",
                table: "Customer");

            migrationBuilder.DropIndex(
                name: "$14",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Allow Line Disc_",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Application Method",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Base Calendar Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Bill-to Customer No_",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Block Payment Tolerance",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Budgeted Amount",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Cash Flow Payment Terms Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Collection Method",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Contact Graph Id",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Contact ID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Contact Type",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Copy Sell-to Addr_ to Qte From",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Created by User",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Currency Id",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Customer ID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Customer Posting Group",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Customer Price Group",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Date Created",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Default Weight",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Document Sending Profile",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Fax No_",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Fin_ Charge Terms Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Gen_ Bus_ Posting Group",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "GLN",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Global Dimension 1 Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Global Dimension 2 Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "IC Partner Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Invoice Copies",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Invoice Disc_ Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Last Date Modified",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Last Modified Date Time",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Last Statement No_",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Location Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "No_ Series",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Other Tender in Finalizing",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Our Account No_",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Partner Type",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Payment Method Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Payment Method Id",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Payment Terms Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Payment Terms Id",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Picture",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Place of Export",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Post as Shipment",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Prepayment _",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Prices Including VAT",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Primary Contact No_",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Print Document Invoice",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Print Statements",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Privacy Blocked",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Reason Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Reminder Terms Code",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Reserve",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Responsibility Center",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Restriction Functionality",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Retail Customer Group",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Shipment Method Id",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Shipping Time",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Tax Area ID",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Telex Answer Back",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "Validate EU Vat Reg_ No_",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "VAT Bus_ Posting Group",
                table: "Customer");

            migrationBuilder.RenameColumn(
                name: "Tax Liable",
                table: "Customer",
                newName: "TaxLiable");

            migrationBuilder.RenameColumn(
                name: "Shipping Advice",
                table: "Customer",
                newName: "ContactInfoId");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    ContactInfoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItemRatings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RatingScore = table.Column<int>(nullable: false),
                    ItemSKU = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ReviewDate = table.Column<int>(nullable: false),
                    Title = table.Column<string>(maxLength: 50, nullable: false),
                    Message = table.Column<string>(maxLength: 250, nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ItemRatings");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "TaxLiable",
                table: "Customer",
                newName: "Tax Liable");

            migrationBuilder.RenameColumn(
                name: "ContactInfoId",
                table: "Customer",
                newName: "Shipping Advice");

            migrationBuilder.AddColumn<byte>(
                name: "Allow Line Disc_",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "Application Method",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Base Calendar Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Bill-to Customer No_",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Block Payment Tolerance",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<decimal>(
                name: "Budgeted Amount",
                table: "Customer",
                type: "decimal(38, 20)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Cash Flow Payment Terms Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Collection Method",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contact Graph Id",
                table: "Customer",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Contact ID",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Contact Type",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Copy Sell-to Addr_ to Qte From",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Created by User",
                table: "Customer",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Currency Id",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Customer ID",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Customer Posting Group",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Customer Price Group",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date Created",
                table: "Customer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Default Weight",
                table: "Customer",
                type: "decimal(38, 20)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Document Sending Profile",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fax No_",
                table: "Customer",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Fin_ Charge Terms Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gen_ Bus_ Posting Group",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GLN",
                table: "Customer",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Global Dimension 1 Code",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Global Dimension 2 Code",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IC Partner Code",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Image",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Invoice Copies",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Invoice Disc_ Code",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "Last Date Modified",
                table: "Customer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Last Modified Date Time",
                table: "Customer",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Last Statement No_",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Location Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "No_ Series",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Other Tender in Finalizing",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Our Account No_",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Partner Type",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Payment Method Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Payment Method Id",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Payment Terms Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Payment Terms Id",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<byte[]>(
                name: "Picture",
                table: "Customer",
                type: "image",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Place of Export",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Post as Shipment",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<decimal>(
                name: "Prepayment _",
                table: "Customer",
                type: "decimal(38, 20)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<byte>(
                name: "Prices Including VAT",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Primary Contact No_",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Print Document Invoice",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<byte>(
                name: "Print Statements",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<byte>(
                name: "Privacy Blocked",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "Reason Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Reminder Terms Code",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Reserve",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Responsibility Center",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Restriction Functionality",
                table: "Customer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Retail Customer Group",
                table: "Customer",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Shipment Method Id",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Shipping Time",
                table: "Customer",
                unicode: false,
                maxLength: 32,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "Tax Area ID",
                table: "Customer",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Telex Answer Back",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte>(
                name: "Validate EU Vat Reg_ No_",
                table: "Customer",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddColumn<string>(
                name: "VAT Bus_ Posting Group",
                table: "Customer",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Customer",
                columns: new[] { "Customer Posting Group", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Customer",
                columns: new[] { "Gen_ Bus_ Posting Group", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$14",
                table: "Customer",
                columns: new[] { "Retail Customer Group", "No_" },
                unique: true);
        }
    }
}
