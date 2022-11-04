using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class AddInvoiceDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(9269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 381, DateTimeKind.Local).AddTicks(6291));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(8847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 381, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductCategories",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 379, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 379, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Invoices",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 376, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(671),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 376, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Invoices",
                maxLength: 300,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 374, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 374, DateTimeKind.Local).AddTicks(4997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 791, DateTimeKind.Local).AddTicks(6919),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 370, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 788, DateTimeKind.Local).AddTicks(400),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 366, DateTimeKind.Local).AddTicks(8475));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Invoices");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 381, DateTimeKind.Local).AddTicks(6291),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 381, DateTimeKind.Local).AddTicks(5888),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 379, DateTimeKind.Local).AddTicks(9164),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 379, DateTimeKind.Local).AddTicks(8826),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Invoices",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 376, DateTimeKind.Local).AddTicks(4918),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 376, DateTimeKind.Local).AddTicks(1222),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 374, DateTimeKind.Local).AddTicks(5511),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 374, DateTimeKind.Local).AddTicks(4997),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 370, DateTimeKind.Local).AddTicks(6321),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 791, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 2, 20, 29, 49, 366, DateTimeKind.Local).AddTicks(8475),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 788, DateTimeKind.Local).AddTicks(400));
        }
    }
}
