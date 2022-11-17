using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 397, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(3029));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.InsertData(
                table: "InvoiceDetails",
                columns: new[] { "InvoiceId", "ProductId", "ItemAmount", "ItemDiscountAmount", "ItemDiscountPercent", "Quantity" },
                values: new object[,]
                {
                    { 1, 2, 1m, 0m, 0m, 0m },
                    { 1, 3, 2m, 0m, 0m, 0m },
                    { 1, 4, 3m, 0m, 0m, 0m },
                    { 1, 5, 2m, 0m, 0m, 0m }
                });

            migrationBuilder.InsertData(
                table: "Invoices",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "CustomerId", "Description", "ModifiedBy", "ModifiedDate", "TotalDiscountAmount", "TotalDiscountPercent", "TotalInvoiceAmount" },
                values: new object[] { 2, "admin", new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(6152), 1, "", null, null, 0m, 0m, 1500000m });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 399, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 399, DateTimeKind.Local).AddTicks(9242));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 399, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5302));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5370));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5372));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5384));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5392));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5411));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 12, 9, 58, 7, 400, DateTimeKind.Local).AddTicks(5421));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InvoiceDetails",
                keyColumns: new[] { "InvoiceId", "ProductId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "InvoiceDetails",
                keyColumns: new[] { "InvoiceId", "ProductId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "InvoiceDetails",
                keyColumns: new[] { "InvoiceId", "ProductId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "InvoiceDetails",
                keyColumns: new[] { "InvoiceId", "ProductId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "Invoices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 746, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(1912));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 748, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 748, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 748, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4131));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4133));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4135));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4136));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4140));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4141));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4143));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4148));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4153));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4154));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4156));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4158));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4164));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 49, 749, DateTimeKind.Local).AddTicks(4172));
        }
    }
}
