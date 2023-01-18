using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class NewInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "2ac15b5e-bc84-4304-a288-b8bdaf1387c5");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "8bbb224b-e309-410c-8278-7222eccad793", new DateTime(2023, 1, 16, 21, 30, 46, 38, DateTimeKind.Local).AddTicks(3719), "AQAAAAEAACcQAAAAENkWsVXtfpdeiqRvCBUSYNKEs7iGDCtllpuNw502ejP4P3F04+efZ6930PRKCC6WQg==" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedBy", "CreatedDate", "Description", "EmailAddress", "FullName", "Gender", "IdentifyCard", "ModifiedBy", "ModifiedDate", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Khánh Hoà", new DateTime(1997, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(1676), "", "tientnguyen24@gmail.com", "Nguyễn Trung Tiến", 0, "056097008352", "", null, "0327264465" },
                    { 2, "Khánh Hoà", new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(3143), "", "thanhlamtran.32@gmail.com", "Trần Thanh Lâm", 0, "056097008351", "", null, "0349616325" },
                    { 3, "Khánh Hoà", new DateTime(2004, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(3207), "", "thuytrang160504@gmail.com", "Nguyễn Thuỳ Trang", 1, "056097008353", "", null, "0346118102" },
                    { 4, "Khánh Hoà", new DateTime(1991, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(3212), "", "luutrongtan1991@gmail.com", "Lưu Trọng Tấn", 0, "056097008354", "", null, "0346113214" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 17, DateTimeKind.Local).AddTicks(9687), "", null, "Dịch vụ nha khoa" },
                    { 2, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 19, DateTimeKind.Local).AddTicks(5009), "", null, "Vật tư nha khoa" },
                    { 3, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 19, DateTimeKind.Local).AddTicks(5099), "", null, "Khác" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name", "ProductCategoryId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(4572), "", null, "Khám và tư vấn", 1, 0m },
                    { 24, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5957), "", null, "Răng nhựa tháo lắp - Răng Ý", 1, 250000m },
                    { 23, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5953), "", null, "Răng nhựa tháo lắp - Răng Nhật", 1, 200000m },
                    { 22, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5949), "", null, "Răng nhựa tháo lắp - Răng Việt Nam", 1, 150000m },
                    { 21, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5945), "", null, "Răng sứ cao cấp - Lava Plus", 1, 6000000m },
                    { 20, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5942), "", null, "Răng sứ cao cấp - Cercon HT", 1, 4000000m },
                    { 19, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5939), "", null, "Răng sứ cao cấp - DDBio", 1, 3500000m },
                    { 18, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5936), "", null, "Răng sứ cao cấp - Zirconia", 1, 3000000m },
                    { 17, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5932), "", null, "Răng sứ - Hợp kim Titan", 1, 1200000m },
                    { 16, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5929), "", null, "Răng sứ - Kim loại Mỹ", 1, 700000m },
                    { 15, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5926), "", null, "Implant", 1, 24000000m },
                    { 14, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5923), "", null, "Chỉnh nha", 1, 25000000m },
                    { 13, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5919), "", null, "Tẩy trắng răng tại phòng khám", 1, 1400000m },
                    { 12, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5916), "", null, "Tẩy trắng răng tại nhà", 1, 650000m },
                    { 11, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5913), "", null, "Chữa răng - nội nha răng cối lớn (số 6, số 7)", 1, 400000m },
                    { 10, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5910), "", null, "Chữa răng - nội nha răng cối nhỏ (số 4, số 5)", 1, 200000m },
                    { 9, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5906), "", null, "Chữa răng - nội nha răng cửa (số 1, số 2, số 3)", 1, 200000m },
                    { 8, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5903), "", null, "Chữa răng - nội nha răng trẻ em", 1, 100000m },
                    { 7, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5900), "", null, "Nhổ răng khôn", 1, 400000m },
                    { 6, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5896), "", null, "Nhổ răng cối lớn (số 6, số 7)", 1, 300000m },
                    { 5, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5893), "", null, "Nhổ răng cối nhỏ (số 4, số 5)", 1, 150000m },
                    { 4, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5889), "", null, "Nhổ răng cửa (số 1, số 2, số 3)", 1, 100000m },
                    { 3, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5884), "", null, "Cạo vôi răng, đánh bóng răng", 1, 50000m },
                    { 2, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5798), "", null, "Chụp phim", 1, 0m },
                    { 25, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5960), "", null, "Răng nhựa tháo lắp - Hàm khung kim loại", 1, 1000000m },
                    { 26, "admin", new DateTime(2023, 1, 16, 21, 30, 46, 21, DateTimeKind.Local).AddTicks(5963), "", null, "Răng nhựa tháo lắp - Nền dẻo", 1, 800000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "374aeef7-9515-466e-ac35-bc06de77f24d");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash" },
                values: new object[] { "62bd8484-b231-42bd-a936-c5bf212ae84c", new DateTime(2022, 11, 20, 22, 45, 25, 8, DateTimeKind.Local).AddTicks(4509), "AQAAAAEAACcQAAAAEMjVqMJ4zWMuyLD/12LRHu1QLt0khAOLdSwL701iCqpEMLzid65JEPG8suP3eCefgg==" });
        }
    }
}
