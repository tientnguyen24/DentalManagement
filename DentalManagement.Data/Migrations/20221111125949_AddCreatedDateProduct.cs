using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class AddCreatedDateProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 49, 157, DateTimeKind.Local).AddTicks(5721),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 78, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 49, 150, DateTimeKind.Local).AddTicks(9059),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 74, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 49, 148, DateTimeKind.Local).AddTicks(3180),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 71, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 166, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(3134));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(7390));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8463));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8523));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8525));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8528));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8547));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 49, 167, DateTimeKind.Local).AddTicks(8558));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 78, DateTimeKind.Local).AddTicks(3885),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 49, 157, DateTimeKind.Local).AddTicks(5721));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 74, DateTimeKind.Local).AddTicks(3455),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 49, 150, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 71, DateTimeKind.Local).AddTicks(6392),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 49, 148, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 94, DateTimeKind.Local).AddTicks(9569));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(6636));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(6639));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(1294));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(7701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8854));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 19, 59, 8, 96, DateTimeKind.Local).AddTicks(8882));
        }
    }
}
