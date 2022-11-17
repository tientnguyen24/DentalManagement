using DentalManagement.Data.Entities;
using DentalManagement.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Extensions
{
	public static class ModelBuilderExtensions
	{
		public static void Seed(this ModelBuilder modelBuilder)
		{
            #region
            modelBuilder.Entity<Account>().HasData
				(
					new Account()
					{
						UserName = "admin",
						Password = "123456",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						Type = Enums.Type.Administrator
					}
				);
            #endregion
            #region
            modelBuilder.Entity<ProductCategory>().HasData
				(
					new ProductCategory()
					{
						Id = 000001,
						Name = "Dịch vụ nha khoa",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = ""
					},
					new ProductCategory()
					{
						Id = 000002,
						Name = "Vật tư nha khoa",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = ""
					},
					new ProductCategory()
					{
						Id = 000003,
						Name = "Khác",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = ""
					}
				);
            #endregion
            #region
            modelBuilder.Entity<Customer>().HasData
				(
					new Customer()
					{
						Id = 000001,
						FullName = "Nguyễn Trung Tiến",
						Gender = Enums.Gender.Male,
						BirthDay = new DateTime(1997, 10, 24),
						Address = "Khánh Hoà",
						PhoneNumber = "0327264465",
						EmailAddress = "tientnguyen24@gmail.com",
						IdentifyCard = "056097008352",
						Status = Enums.Status.Active,
						Description = "",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = ""
					},
					new Customer()
					{
						Id = 000002,
						FullName = "Trần Thanh Lâm",
						Gender = Enums.Gender.Male,
						BirthDay = new DateTime(1997, 02, 03),
						Address = "Khánh Hoà",
						PhoneNumber = "0349616325",
						EmailAddress = "thanhlamtran.32@gmail.com",
						IdentifyCard = "056097008351",
						Status = Enums.Status.Active,
						Description = "",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = ""
					},
					new Customer()
					{
						Id = 000003,
						FullName = "Nguyễn Thuỳ Trang",
						Gender = Enums.Gender.Female,
						BirthDay = new DateTime(2004, 05, 16),
						Address = "Khánh Hoà",
						PhoneNumber = "0346118102",
						EmailAddress = "thuytrang160504@gmail.com",
						IdentifyCard = "056097008353",
						Status = Enums.Status.Active,
						Description = "",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = ""
					},
					new Customer()
					{
						Id = 000004,
						FullName = "Lưu Trọng Tấn",
						Gender = Enums.Gender.Male,
						BirthDay = new DateTime(1991, 10, 28),
						Address = "Khánh Hoà",
						PhoneNumber = "0346113214",
						EmailAddress = "luutrongtan1991@gmail.com",
						IdentifyCard = "056097008354",
						Status = Enums.Status.Active,
						Description = "",
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = ""
					}
				);
			#endregion
            #region
            modelBuilder.Entity<Product>().HasData
				(
					new Product()
					{
						Id = 000001,
						Name = "Khám và tư vấn",
						UnitPrice = 0,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000002,
						Name = "Chụp phim",
						UnitPrice = 0,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000003,
						Name = "Cạo vôi răng, đánh bóng răng",
						UnitPrice = 50000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000004,
						Name = "Nhổ răng cửa (số 1, số 2, số 3)",
						UnitPrice = 100000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000005,
						Name = "Nhổ răng cối nhỏ (số 4, số 5)",
						UnitPrice = 150000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000006,
						Name = "Nhổ răng cối lớn (số 6, số 7)",
						UnitPrice = 300000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000007,
						Name = "Nhổ răng khôn",
						UnitPrice = 400000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000008,
						Name = "Chữa răng - nội nha răng trẻ em",
						UnitPrice = 100000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000009,
						Name = "Chữa răng - nội nha răng cửa (số 1, số 2, số 3)",
						UnitPrice = 200000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000010,
						Name = "Chữa răng - nội nha răng cối nhỏ (số 4, số 5)",
						UnitPrice = 200000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000011,
						Name = "Chữa răng - nội nha răng cối lớn (số 6, số 7)",
						UnitPrice = 400000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000012,
						Name = "Tẩy trắng răng tại nhà",
						UnitPrice = 650000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000013,
						Name = "Tẩy trắng răng tại phòng khám",
						UnitPrice = 1400000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000014,
						Name = "Chỉnh nha",
						UnitPrice = 25000000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000015,
						Name = "Implant",
						UnitPrice = 24000000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000016,
						Name = "Răng sứ - Kim loại Mỹ",
						UnitPrice = 700000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000017,
						Name = "Răng sứ - Hợp kim Titan",
						UnitPrice = 1200000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000018,
						Name = "Răng sứ cao cấp - Zirconia",
						UnitPrice = 3000000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000019,
						Name = "Răng sứ cao cấp - DDBio",
						UnitPrice = 3500000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000020,
						Name = "Răng sứ cao cấp - Cercon HT",
						UnitPrice = 4000000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000021,
						Name = "Răng sứ cao cấp - Lava Plus",
						UnitPrice = 6000000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000022,
						Name = "Răng nhựa tháo lắp - Răng Việt Nam",
						UnitPrice = 150000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000023,
						Name = "Răng nhựa tháo lắp - Răng Nhật",
						UnitPrice = 200000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000024,
						Name = "Răng nhựa tháo lắp - Răng Ý",
						UnitPrice = 250000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000025,
						Name = "Răng nhựa tháo lắp - Hàm khung kim loại",
						UnitPrice = 1000000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					},
					new Product()
					{
						Id = 000026,
						Name = "Răng nhựa tháo lắp - Nền dẻo",
						UnitPrice = 800000,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						ModifiedDate = null,
						ModifiedBy = "",
						ProductCategoryId = 000001
					}
				);
			#endregion
			#region
			modelBuilder.Entity<Invoice>().HasData
				(
					new Invoice()
					{
						Id = 2,
						CreatedDate = DateTime.Now,
						CreatedBy = "admin",
						TotalDiscountPercent = 0,
						TotalDiscountAmount = 0,
						TotalInvoiceAmount = 1500000,
						CustomerId = 1,
						Description = "",
						Status = Status.Active,
					}
				);
            #endregion
            #region
            modelBuilder.Entity<InvoiceDetail>().HasData
				(
					new InvoiceDetail()
                    {
						InvoiceId = 1,
						ProductId = 2,
						ItemDiscountPercent = 0,
						ItemDiscountAmount = 0,
						ItemAmount = 1,
                    },
                    new InvoiceDetail()
                    {
                        InvoiceId = 1,
                        ProductId = 3,
                        ItemDiscountPercent = 0,
                        ItemDiscountAmount = 0,
                        ItemAmount = 2,
                    },
                    new InvoiceDetail()
                    {
                        InvoiceId = 1,
                        ProductId = 4,
                        ItemDiscountPercent = 0,
                        ItemDiscountAmount = 0,
                        ItemAmount = 3,
                    }, new InvoiceDetail()
                    {
                        InvoiceId = 1,
                        ProductId = 5,
                        ItemDiscountPercent = 0,
                        ItemDiscountAmount = 0,
                        ItemAmount = 2,
                    }
                );
            #endregion
        }
    }
}
