using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class AddCreatedDateAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 44, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 78, DateTimeKind.Local).AddTicks(3885),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 43, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 74, DateTimeKind.Local).AddTicks(3455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 34, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 71, DateTimeKind.Local).AddTicks(6392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 33, DateTimeKind.Local).AddTicks(1362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 26, DateTimeKind.Local).AddTicks(1389));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 44, DateTimeKind.Local).AddTicks(8843),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 43, DateTimeKind.Local).AddTicks(1618),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 78, DateTimeKind.Local).AddTicks(3885));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 34, DateTimeKind.Local).AddTicks(7524),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 74, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 33, DateTimeKind.Local).AddTicks(1362),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 19, 59, 8, 71, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 6, 15, 25, 40, 26, DateTimeKind.Local).AddTicks(1389),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 53, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 54, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 54, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 54, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4664));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4668));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4670));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4672));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4683));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4686));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4688));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4690));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4691));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4710));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4715));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4718));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4721));
        }
    }
}
