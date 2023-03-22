using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DentalManagement.Data.Migrations
{
    public partial class AddRemainAmountForInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "RemainAmount",
                table: "Invoices",
                type: "decimal(18,2)",
                maxLength: 100,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "c8083a0b-ed5d-4abd-b5c6-5b54f4b1e5a9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "89297097-e943-4b8d-8fa4-fd2009784722", new DateTime(2023, 3, 22, 19, 55, 29, 769, DateTimeKind.Local).AddTicks(493), "AQAAAAEAACcQAAAAEMkWzqwYEuUDrcYC49XOYS8VrjlrGbrGTxhr0BN3syil8d/WOhfhP8C2HsT/8xxsyA==" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7644));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7759));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7770));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7786));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7788));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7795));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2023, 3, 22, 19, 55, 29, 767, DateTimeKind.Local).AddTicks(7798));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RemainAmount",
                table: "Invoices");

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
    }
}
