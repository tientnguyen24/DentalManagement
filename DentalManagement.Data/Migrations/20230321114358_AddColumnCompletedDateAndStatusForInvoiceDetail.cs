using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalManagement.Data.Migrations
{
    public partial class AddColumnCompletedDateAndStatusForInvoiceDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CompletedDate",
                table: "InvoiceDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "InvoiceDetails",
                type: "int",
                nullable: false,
                defaultValue: 2);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "335e0541-39c7-40e6-8e39-a1ceebf5fe0f");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "36d4453e-d48f-4996-baf1-f4149c0d25f9", new DateTime(2023, 3, 21, 18, 43, 58, 16, DateTimeKind.Local).AddTicks(9853), "AQAAAAEAACcQAAAAEM299vg1QY9FoSDG7hpRJQnQ8kz5xUjh0VZqI4i9RVVFflej6hY+2+StzK/brWuItQ==" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7396));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7401));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7404));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7240));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7241));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7423));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7426));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7435));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7439));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7442));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7448));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7453));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 21, 18, 43, 58, 15, DateTimeKind.Local).AddTicks(7455));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompletedDate",
                table: "InvoiceDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "InvoiceDetails");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c5a2a610-bf5a-4288-8ba1-70d1bbb299f9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "3fb11715-c9d0-4c35-a0a9-8fe09415c5d0", new DateTime(2023, 3, 11, 21, 54, 13, 808, DateTimeKind.Local).AddTicks(507), "AQAAAAEAACcQAAAAEAKMhCqqtZ7U61BzAwaTVDZCXd3a5xeCSNlynbAHaRQKT5z914rZb6chB/Zq0WLVRA==" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7841));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7845));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7858));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7868));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7881));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7886));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7895));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7897));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7899));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 11, 21, 54, 13, 806, DateTimeKind.Local).AddTicks(7901));
        }
    }
}
