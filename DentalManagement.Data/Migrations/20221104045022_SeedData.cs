using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 890, DateTimeKind.Local).AddTicks(846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(9269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 890, DateTimeKind.Local).AddTicks(521),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductCategories",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 888, DateTimeKind.Local).AddTicks(7320),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 888, DateTimeKind.Local).AddTicks(6967),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Invoices",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 885, DateTimeKind.Local).AddTicks(6917),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(4593));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 885, DateTimeKind.Local).AddTicks(3456),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 883, DateTimeKind.Local).AddTicks(7139),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 883, DateTimeKind.Local).AddTicks(6894),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 880, DateTimeKind.Local).AddTicks(3831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 791, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 877, DateTimeKind.Local).AddTicks(1092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 788, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "UserName", "CreatedBy", "CreatedDate", "ModifiedBy", "Password", "Type" },
                values: new object[] { "admin", "admin", new DateTime(2022, 11, 4, 11, 50, 21, 900, DateTimeKind.Local).AddTicks(8128), "", "123456", 0 });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedBy", "CreatedDate", "Description", "EmailAddress", "FullName", "Gender", "IdentifyCard", "ModifiedBy", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Khánh Hoà", new DateTime(1997, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(1647), "", "tientnguyen24@gmail.com", "Nguyễn Trung Tiến", 0, "056097008352", "", "0327264465" },
                    { 2, "Khánh Hoà", new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(2683), "", "thanhlamtran.32@gmail.com", "Trần Thanh Lâm", 0, "056097008351", "", "0349616325" },
                    { 3, "Khánh Hoà", new DateTime(2004, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(2730), "", "thuytrang160504@gmail.com", "Nguyễn Thuỳ Trang", 1, "056097008353", "", "0346118102" },
                    { 4, "Khánh Hoà", new DateTime(1991, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(2734), "", "luutrongtan1991@gmail.com", "Lưu Trọng Tấn", 0, "056097008354", "", "0346113214" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 901, DateTimeKind.Local).AddTicks(8327), "", "Dịch vụ nha khoa" },
                    { 2, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 901, DateTimeKind.Local).AddTicks(9337), "", "Vật tư nha khoa" },
                    { 3, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 901, DateTimeKind.Local).AddTicks(9365), "", "Khác" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "Name", "ProductCategoryId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(3736), "", "Khám và tư vấn", 1, 0m },
                    { 24, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4896), "", "Răng nhựa tháo lắp - Răng Ý", 1, 250000m },
                    { 23, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4895), "", "Răng nhựa tháo lắp - Răng Nhật", 1, 200000m },
                    { 22, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4893), "", "Răng nhựa tháo lắp - Răng Việt Nam", 1, 150000m },
                    { 21, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4892), "", "Răng sứ cao cấp - Lava Plus", 1, 6000000m },
                    { 20, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4890), "", "Răng sứ cao cấp - Cercon HT", 1, 4000000m },
                    { 19, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4889), "", "Răng sứ cao cấp - DDBio", 1, 3500000m },
                    { 18, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4887), "", "Răng sứ cao cấp - Zirconia", 1, 3000000m },
                    { 17, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4886), "", "Răng sứ - Hợp kim Titan", 1, 1200000m },
                    { 16, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4884), "", "Răng sứ - Kim loại Mỹ", 1, 700000m },
                    { 15, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4883), "", "Implant", 1, 24000000m },
                    { 14, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4881), "", "Chỉnh nha", 1, 25000000m },
                    { 13, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4880), "", "Tẩy trắng răng tại phòng khám", 1, 1400000m },
                    { 12, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4879), "", "Tẩy trắng răng tại nhà", 1, 650000m },
                    { 11, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4877), "", "Chữa răng - nội nha răng cối lớn (số 6, số 7)", 1, 400000m },
                    { 10, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4876), "", "Chữa răng - nội nha răng cối nhỏ (số 4, số 5)", 1, 200000m },
                    { 9, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4874), "", "Chữa răng - nội nha răng cửa (số 1, số 2, số 3)", 1, 200000m },
                    { 8, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4872), "", "Chữa răng - nội nha răng trẻ em", 1, 100000m },
                    { 7, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4870), "", "Nhổ răng khôn", 1, 400000m },
                    { 6, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4869), "", "Nhổ răng cối lớn (số 6, số 7)", 1, 300000m },
                    { 5, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4867), "", "Nhổ răng cối nhỏ (số 4, số 5)", 1, 150000m },
                    { 4, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4865), "", "Nhổ răng cửa (số 1, số 2, số 3)", 1, 100000m },
                    { 3, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4863), "", "Cạo vôi răng, đánh bóng răng", 1, 50000m },
                    { 2, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4808), "", "Chụp phim", 1, 0m },
                    { 25, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4897), "", "Răng nhựa tháo lắp - Hàm khung kim loại", 1, 1000000m },
                    { 26, "admin", new DateTime(2022, 11, 4, 11, 50, 21, 902, DateTimeKind.Local).AddTicks(4899), "", "Răng nhựa tháo lắp - Nền dẻo", 1, 800000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Accounts",
                keyColumn: "UserName",
                keyValue: "admin");

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(9269),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 890, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 802, DateTimeKind.Local).AddTicks(8847),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 890, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2952),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 888, DateTimeKind.Local).AddTicks(7320));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ProductCategories",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 801, DateTimeKind.Local).AddTicks(2149),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 888, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Invoices",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(4593),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 885, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 797, DateTimeKind.Local).AddTicks(671),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 885, DateTimeKind.Local).AddTicks(3456));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4460),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 883, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Customers",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 795, DateTimeKind.Local).AddTicks(4182),
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 883, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 791, DateTimeKind.Local).AddTicks(6919),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 880, DateTimeKind.Local).AddTicks(3831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Accounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 11, 3, 18, 51, 45, 788, DateTimeKind.Local).AddTicks(400),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2022, 11, 4, 11, 50, 21, 877, DateTimeKind.Local).AddTicks(1092));
        }
    }
}
