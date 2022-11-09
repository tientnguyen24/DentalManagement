﻿// <auto-generated />
using System;
using DentalManagement.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DentalManagement.Data.Migrations
{
    [DbContext(typeof(DentalManagementDbContext))]
    [Migration("20221106082540_AddStatusProduct")]
    partial class AddStatusProduct
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DentalManagement.Data.Entities.Account", b =>
                {
                    b.Property<string>("UserName")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 6, 15, 25, 40, 26, DateTimeKind.Local).AddTicks(1389));

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("UserName");

                    b.ToTable("Accounts");

                    b.HasData(
                        new
                        {
                            UserName = "admin",
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 53, DateTimeKind.Local).AddTicks(4614),
                            ModifiedBy = "",
                            Password = "123456",
                            Status = 0,
                            Type = 0
                        });
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("BirthDay")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 6, 15, 25, 40, 33, DateTimeKind.Local).AddTicks(1362));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("EmailAddress")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("IdentifyCard")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.HasKey("Id");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Khánh Hoà",
                            BirthDay = new DateTime(1997, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(702),
                            Description = "",
                            EmailAddress = "tientnguyen24@gmail.com",
                            FullName = "Nguyễn Trung Tiến",
                            Gender = 0,
                            IdentifyCard = "056097008352",
                            ModifiedBy = "",
                            PhoneNumber = "0327264465",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Address = "Khánh Hoà",
                            BirthDay = new DateTime(1997, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(1956),
                            Description = "",
                            EmailAddress = "thanhlamtran.32@gmail.com",
                            FullName = "Trần Thanh Lâm",
                            Gender = 0,
                            IdentifyCard = "056097008351",
                            ModifiedBy = "",
                            PhoneNumber = "0349616325",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Address = "Khánh Hoà",
                            BirthDay = new DateTime(2004, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(2003),
                            Description = "",
                            EmailAddress = "thuytrang160504@gmail.com",
                            FullName = "Nguyễn Thuỳ Trang",
                            Gender = 1,
                            IdentifyCard = "056097008353",
                            ModifiedBy = "",
                            PhoneNumber = "0346118102",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Address = "Khánh Hoà",
                            BirthDay = new DateTime(1991, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(2006),
                            Description = "",
                            EmailAddress = "luutrongtan1991@gmail.com",
                            FullName = "Lưu Trọng Tấn",
                            Gender = 0,
                            IdentifyCard = "056097008354",
                            ModifiedBy = "",
                            PhoneNumber = "0346113214",
                            Status = 0
                        });
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 6, 15, 25, 40, 34, DateTimeKind.Local).AddTicks(7524));

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(300)")
                        .HasMaxLength(300);

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("TotalDiscountAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(100);

                    b.Property<decimal>("TotalDiscountPercent")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(50);

                    b.Property<decimal>("TotalInvoiceAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.InvoiceDetail", b =>
                {
                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<decimal>("ItemAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(100);

                    b.Property<decimal>("ItemDiscountAmount")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(100);

                    b.Property<decimal>("ItemDiscountPercent")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(100);

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoiceId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 6, 15, 25, 40, 44, DateTimeKind.Local).AddTicks(8843));

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(3210),
                            ModifiedBy = "",
                            Name = "Khám và tư vấn",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 0m
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4561),
                            ModifiedBy = "",
                            Name = "Chụp phim",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 0m
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4664),
                            ModifiedBy = "",
                            Name = "Cạo vôi răng, đánh bóng răng",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 50000m
                        },
                        new
                        {
                            Id = 4,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4668),
                            ModifiedBy = "",
                            Name = "Nhổ răng cửa (số 1, số 2, số 3)",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 100000m
                        },
                        new
                        {
                            Id = 5,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4670),
                            ModifiedBy = "",
                            Name = "Nhổ răng cối nhỏ (số 4, số 5)",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 150000m
                        },
                        new
                        {
                            Id = 6,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4672),
                            ModifiedBy = "",
                            Name = "Nhổ răng cối lớn (số 6, số 7)",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 300000m
                        },
                        new
                        {
                            Id = 7,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4674),
                            ModifiedBy = "",
                            Name = "Nhổ răng khôn",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 400000m
                        },
                        new
                        {
                            Id = 8,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4676),
                            ModifiedBy = "",
                            Name = "Chữa răng - nội nha răng trẻ em",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 100000m
                        },
                        new
                        {
                            Id = 9,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4681),
                            ModifiedBy = "",
                            Name = "Chữa răng - nội nha răng cửa (số 1, số 2, số 3)",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 200000m
                        },
                        new
                        {
                            Id = 10,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4683),
                            ModifiedBy = "",
                            Name = "Chữa răng - nội nha răng cối nhỏ (số 4, số 5)",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 200000m
                        },
                        new
                        {
                            Id = 11,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4685),
                            ModifiedBy = "",
                            Name = "Chữa răng - nội nha răng cối lớn (số 6, số 7)",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 400000m
                        },
                        new
                        {
                            Id = 12,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4686),
                            ModifiedBy = "",
                            Name = "Tẩy trắng răng tại nhà",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 650000m
                        },
                        new
                        {
                            Id = 13,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4688),
                            ModifiedBy = "",
                            Name = "Tẩy trắng răng tại phòng khám",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 1400000m
                        },
                        new
                        {
                            Id = 14,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4690),
                            ModifiedBy = "",
                            Name = "Chỉnh nha",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 25000000m
                        },
                        new
                        {
                            Id = 15,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4691),
                            ModifiedBy = "",
                            Name = "Implant",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 24000000m
                        },
                        new
                        {
                            Id = 16,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4702),
                            ModifiedBy = "",
                            Name = "Răng sứ - Kim loại Mỹ",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 700000m
                        },
                        new
                        {
                            Id = 17,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4704),
                            ModifiedBy = "",
                            Name = "Răng sứ - Hợp kim Titan",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 1200000m
                        },
                        new
                        {
                            Id = 18,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4706),
                            ModifiedBy = "",
                            Name = "Răng sứ cao cấp - Zirconia",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 3000000m
                        },
                        new
                        {
                            Id = 19,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4708),
                            ModifiedBy = "",
                            Name = "Răng sứ cao cấp - DDBio",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 3500000m
                        },
                        new
                        {
                            Id = 20,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4710),
                            ModifiedBy = "",
                            Name = "Răng sứ cao cấp - Cercon HT",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 4000000m
                        },
                        new
                        {
                            Id = 21,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4711),
                            ModifiedBy = "",
                            Name = "Răng sứ cao cấp - Lava Plus",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 6000000m
                        },
                        new
                        {
                            Id = 22,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4713),
                            ModifiedBy = "",
                            Name = "Răng nhựa tháo lắp - Răng Việt Nam",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 150000m
                        },
                        new
                        {
                            Id = 23,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4715),
                            ModifiedBy = "",
                            Name = "Răng nhựa tháo lắp - Răng Nhật",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 200000m
                        },
                        new
                        {
                            Id = 24,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4718),
                            ModifiedBy = "",
                            Name = "Răng nhựa tháo lắp - Răng Ý",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 250000m
                        },
                        new
                        {
                            Id = 25,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4719),
                            ModifiedBy = "",
                            Name = "Răng nhựa tháo lắp - Hàm khung kim loại",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 1000000m
                        },
                        new
                        {
                            Id = 26,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 55, DateTimeKind.Local).AddTicks(4721),
                            ModifiedBy = "",
                            Name = "Răng nhựa tháo lắp - Nền dẻo",
                            ProductCategoryId = 1,
                            Status = 0,
                            UnitPrice = 800000m
                        });
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:IdentityIncrement", 1)
                        .HasAnnotation("SqlServer:IdentitySeed", 1)
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 11, 6, 15, 25, 40, 43, DateTimeKind.Local).AddTicks(1618));

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 54, DateTimeKind.Local).AddTicks(6719),
                            ModifiedBy = "",
                            Name = "Dịch vụ nha khoa"
                        },
                        new
                        {
                            Id = 2,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 54, DateTimeKind.Local).AddTicks(7911),
                            ModifiedBy = "",
                            Name = "Vật tư nha khoa"
                        },
                        new
                        {
                            Id = 3,
                            CreatedBy = "admin",
                            CreatedDate = new DateTime(2022, 11, 6, 15, 25, 40, 54, DateTimeKind.Local).AddTicks(7941),
                            ModifiedBy = "",
                            Name = "Khác"
                        });
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.Invoice", b =>
                {
                    b.HasOne("DentalManagement.Data.Entities.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.InvoiceDetail", b =>
                {
                    b.HasOne("DentalManagement.Data.Entities.Invoice", "Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DentalManagement.Data.Entities.Product", "Product")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DentalManagement.Data.Entities.Product", b =>
                {
                    b.HasOne("DentalManagement.Data.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
