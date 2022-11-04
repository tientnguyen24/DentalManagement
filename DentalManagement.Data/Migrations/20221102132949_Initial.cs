using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    UserName = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Password = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 366, DateTimeKind.Local).AddTicks(8475)),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 370, DateTimeKind.Local).AddTicks(6321)),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.UserName);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Gender = table.Column<int>(nullable: false),
                    BirthDay = table.Column<DateTime>(nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    PhoneNumber = table.Column<string>(maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    IdentifyCard = table.Column<string>(maxLength: 100, nullable: true),
                    Status = table.Column<int>(nullable: false, defaultValue: 0),
                    Description = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 374, DateTimeKind.Local).AddTicks(4997)),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 374, DateTimeKind.Local).AddTicks(5511)),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 379, DateTimeKind.Local).AddTicks(8826)),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 379, DateTimeKind.Local).AddTicks(9164)),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 376, DateTimeKind.Local).AddTicks(1222)),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: false),
                    TotalDiscountPercent = table.Column<decimal>(maxLength: 50, nullable: false),
                    TotalDiscountAmount = table.Column<decimal>(maxLength: 100, nullable: false),
                    TotalInvoiceAmount = table.Column<decimal>(maxLength: 100, nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 376, DateTimeKind.Local).AddTicks(4918)),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    UnitPrice = table.Column<decimal>(maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 381, DateTimeKind.Local).AddTicks(5888)),
                    CreatedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ModifiedDate = table.Column<DateTime>(nullable: true, defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 381, DateTimeKind.Local).AddTicks(6291)),
                    ModifiedBy = table.Column<string>(maxLength: 100, nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceDetails",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    ItemDiscountPercent = table.Column<decimal>(maxLength: 100, nullable: false),
                    ItemDiscountAmount = table.Column<decimal>(maxLength: 100, nullable: false),
                    ItemAmount = table.Column<decimal>(maxLength: 100, nullable: false),
                    Quantity = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceDetails", x => new { x.InvoiceId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceDetails_ProductId",
                table: "InvoiceDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "InvoiceDetails");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
