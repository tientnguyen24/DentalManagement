using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DentalManagement.Data.Migrations
{
    public partial class AddUserClaimUserRoldUserLoginRoleClaimUserToken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    ProviderKey = table.Column<string>(nullable: true),
                    ProviderDisplayName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "BirthDay", "CreatedBy", "CreatedDate", "Description", "EmailAddress", "FullName", "Gender", "IdentifyCard", "ModifiedBy", "ModifiedDate", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Khánh Hoà", new DateTime(1997, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(1657), "", "tientnguyen24@gmail.com", "Nguyễn Trung Tiến", 0, "056097008352", "", null, "0327264465" },
                    { 2, "Khánh Hoà", new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(2673), "", "thanhlamtran.32@gmail.com", "Trần Thanh Lâm", 0, "056097008351", "", null, "0349616325" },
                    { 3, "Khánh Hoà", new DateTime(2004, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(2716), "", "thuytrang160504@gmail.com", "Nguyễn Thuỳ Trang", 1, "056097008353", "", null, "0346118102" },
                    { 4, "Khánh Hoà", new DateTime(1991, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(2719), "", "luutrongtan1991@gmail.com", "Lưu Trọng Tấn", 0, "056097008354", "", null, "0346113214" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 683, DateTimeKind.Local).AddTicks(162), "", null, "Dịch vụ nha khoa" },
                    { 2, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 683, DateTimeKind.Local).AddTicks(9933), "", null, "Vật tư nha khoa" },
                    { 3, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 683, DateTimeKind.Local).AddTicks(9985), "", null, "Khác" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "ModifiedBy", "ModifiedDate", "Name", "ProductCategoryId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(3793), "", null, "Khám và tư vấn", 1, 0m },
                    { 24, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5093), "", null, "Răng nhựa tháo lắp - Răng Ý", 1, 250000m },
                    { 23, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5092), "", null, "Răng nhựa tháo lắp - Răng Nhật", 1, 200000m },
                    { 22, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5090), "", null, "Răng nhựa tháo lắp - Răng Việt Nam", 1, 150000m },
                    { 21, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5088), "", null, "Răng sứ cao cấp - Lava Plus", 1, 6000000m },
                    { 20, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5087), "", null, "Răng sứ cao cấp - Cercon HT", 1, 4000000m },
                    { 19, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5085), "", null, "Răng sứ cao cấp - DDBio", 1, 3500000m },
                    { 18, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5084), "", null, "Răng sứ cao cấp - Zirconia", 1, 3000000m },
                    { 17, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5082), "", null, "Răng sứ - Hợp kim Titan", 1, 1200000m },
                    { 16, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5080), "", null, "Răng sứ - Kim loại Mỹ", 1, 700000m },
                    { 15, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5078), "", null, "Implant", 1, 24000000m },
                    { 14, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5077), "", null, "Chỉnh nha", 1, 25000000m },
                    { 13, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5075), "", null, "Tẩy trắng răng tại phòng khám", 1, 1400000m },
                    { 12, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5073), "", null, "Tẩy trắng răng tại nhà", 1, 650000m },
                    { 11, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5071), "", null, "Chữa răng - nội nha răng cối lớn (số 6, số 7)", 1, 400000m },
                    { 10, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5070), "", null, "Chữa răng - nội nha răng cối nhỏ (số 4, số 5)", 1, 200000m },
                    { 9, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5066), "", null, "Chữa răng - nội nha răng cửa (số 1, số 2, số 3)", 1, 200000m },
                    { 8, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5064), "", null, "Chữa răng - nội nha răng trẻ em", 1, 100000m },
                    { 7, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5063), "", null, "Nhổ răng khôn", 1, 400000m },
                    { 6, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5060), "", null, "Nhổ răng cối lớn (số 6, số 7)", 1, 300000m },
                    { 5, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5059), "", null, "Nhổ răng cối nhỏ (số 4, số 5)", 1, 150000m },
                    { 4, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5057), "", null, "Nhổ răng cửa (số 1, số 2, số 3)", 1, 100000m },
                    { 3, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5054), "", null, "Cạo vôi răng, đánh bóng răng", 1, 50000m },
                    { 2, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(4950), "", null, "Chụp phim", 1, 0m },
                    { 25, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5095), "", null, "Răng nhựa tháo lắp - Hàm khung kim loại", 1, 1000000m },
                    { 26, "admin", new DateTime(2022, 11, 20, 15, 5, 7, 685, DateTimeKind.Local).AddTicks(5096), "", null, "Răng nhựa tháo lắp - Nền dẻo", 1, 800000m }
                });
        }
    }
}
