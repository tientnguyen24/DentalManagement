using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class AddCreatedDateCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 20, 1, 16, 81, DateTimeKind.Local).AddTicks(6910));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 20, 1, 16, 81, DateTimeKind.Local).AddTicks(6910),
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 101, DateTimeKind.Local).AddTicks(5116));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(1914));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(3066));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 102, DateTimeKind.Local).AddTicks(7673));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 102, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 102, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5726));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5728));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5730));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5732));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5734));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5740));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5760));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5763));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 1, 16, 103, DateTimeKind.Local).AddTicks(5765));
        }
    }
}
