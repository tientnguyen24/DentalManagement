using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class AddPrepaymentAmountForInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "PrepaymentAmount",
                table: "Invoices",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9760133e-386d-445a-980a-6b2f9842fa8c");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "45f7433d-a022-4ab2-8d17-cef913c48d4b", new DateTime(2023, 2, 2, 12, 29, 26, 497, DateTimeKind.Local).AddTicks(9882), "AQAAAAEAACcQAAAAEPBmOaF6lDsDI9Caw4amZCRxg2VhP8hVhD1cTW2+PFKBPoBhC3TlITQzSrNoOWaE8Q==" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 486, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 484, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 485, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 485, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3444));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3527));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3563));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 2, 2, 12, 29, 26, 487, DateTimeKind.Local).AddTicks(3578));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrepaymentAmount",
                table: "Invoices");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "9ef8ee21-22b5-48d2-93b7-13770c603fa8");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "8b9980ae-db28-4f94-8674-6ae37acfa694", new DateTime(2023, 1, 28, 9, 48, 8, 60, DateTimeKind.Local).AddTicks(1806), "AQAAAAEAACcQAAAAEL03kjn4o9Wh0RKnT6Mi4KpsQmvQ0hn8szKyovmlcKKDRFvpnpeD1wPCuPXGXiX56g==" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 50, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 50, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 50, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 50, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 49, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 49, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 49, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(808));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1673));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1695));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 1, 28, 9, 48, 8, 51, DateTimeKind.Local).AddTicks(1703));
        }
    }
}
