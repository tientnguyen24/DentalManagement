using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class AddCreatedDateInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 11, 20, 0, 23, 756, DateTimeKind.Local).AddTicks(317));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 20, 1, 16, 81, DateTimeKind.Local).AddTicks(6910),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 20, 0, 23, 753, DateTimeKind.Local).AddTicks(6007));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 11, 20, 0, 23, 756, DateTimeKind.Local).AddTicks(317),
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 11, 20, 0, 23, 753, DateTimeKind.Local).AddTicks(6007),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 11, 20, 1, 16, 81, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin",
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 771, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(4229));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 772, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(937));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7549));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7552));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7559));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7561));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7567));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7572));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2022, 11, 11, 20, 0, 23, 773, DateTimeKind.Local).AddTicks(7577));
        }
    }
}
