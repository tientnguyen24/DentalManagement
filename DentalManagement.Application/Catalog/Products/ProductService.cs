using DentalManagement.ViewModels.Catalog.Products;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.EF;
using DentalManagement.Data.Entities;
using DentalManagement.Utilities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using DentalManagement.Data.Enums;

namespace DentalManagement.Application.Catalog.Products
{
    public class ProductService : IProductService
    {
        private readonly DentalManagementDbContext _context;
        public ProductService(DentalManagementDbContext context)
        {
            _context = context;
        }
        public async Task<int> Create(ProductCreateRequest request)
        {
            var product = new Product()
            {
                Name = request.Name,
                UnitPrice = request.UnitPrice,
                CreatedDate = DateTime.Now,
                CreatedBy = request.CreatedBy,
                ProductCategoryId = request.ProductCategoryId
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product.Id;
        }

        public async Task<List<ProductViewModel>> GetAll()
        {
            //select product record
            var query = from pc in _context.ProductCategories
                        join p in _context.Products on pc.Id equals p.ProductCategoryId
                        select new { p, pc };
            var data = await query.Select(x => new ProductViewModel()
            {
                Id = x.p.Id,
                Name = x.p.Name,
                UnitPrice = x.p.UnitPrice,
                CreatedDate = x.p.CreatedDate,
                CreatedBy = x.p.CreatedBy,
                ModifiedDate = x.p.ModifiedDate,
                ModifiedBy = x.p.ModifiedBy,
                ProductCategoryId = x.p.ProductCategoryId,
                ProductCategoryName = x.pc.Name,
            }).ToListAsync();
            return data;
        }

        public async Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request)
        {
            //select product record
            var query = from pc in _context.ProductCategories
                        join p in _context.Products on pc.Id equals p.ProductCategoryId
                        select new { p, pc };
            //filter product
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                query = query.Where(x => x.p.Name.Contains(request.Keyword));
            }
            //paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1)*request.PageSize).Take(request.PageSize).Select(x=>new ProductViewModel()
            {
                Id = x.p.Id,
                Name = x.p.Name,
                UnitPrice = x.p.UnitPrice,
                CreatedDate = x.p.CreatedDate,
                CreatedBy = x.p.CreatedBy,
                ModifiedDate = x.p.ModifiedDate,
                ModifiedBy = x.p.ModifiedBy,
                ProductCategoryId = x.p.ProductCategoryId,
				ProductCategoryName = x.pc.Name,
            }).ToListAsync();
            //select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pagedResult;
        }

        public async Task<int> Update(ProductUpdateRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if (product == null)
            {
                throw new DentalManagementException($"Không tìm thấy sản phẩm: {request.Id}");
            }
            else
            {
                product.Name = request.Name;
                product.UnitPrice = request.UnitPrice;
                product.ModifiedDate = DateTime.Now;
                product.ModifiedBy = request.ModifiedBy;
                product.ProductCategoryId = request.ProductCategoryId;
                
            }
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateStatus(int productId, Status updatedStatus)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product == null)
            {
                throw new DentalManagementException($"Không tìm thấy sản phẩm: {productId}");
            }
            else if (product.Status == updatedStatus)
            {
                throw new DentalManagementException($"Trạng thái hiện tại của sản phẩm trùng với trạng thái cần cập nhật.");
            }
            else
            {
                product.Status = updatedStatus;
            }
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<int> Delete(ProductDeleteRequest request)
        {
            var product = await _context.Products.FindAsync(request.Id);
            if(product == null)
            {
                throw new DentalManagementException($"Không tìm thấy sản phẩm: {request.Id}");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ProductViewModel>> GetAllByProductCategoryId(GetProductByCategoryIdRequest request)
        {
            //select product record
            var query = from pc in _context.ProductCategories
                        join p in _context.Products on pc.Id equals p.ProductCategoryId
                        select new { pc, p };
            //filter product
            if (request.ProductCategoryId.HasValue && request.ProductCategoryId.Value > 0)
            {
                query = query.Where(x=>x.pc.Id == request.ProductCategoryId);
                if(query.Count() > 0)
                {
                    var data = await query.Select(x => new ProductViewModel()
                    {
                        Id = x.p.Id,
                        Name = x.p.Name,
                        UnitPrice = x.p.UnitPrice,
                        CreatedDate = x.p.CreatedDate,
                        CreatedBy = x.p.CreatedBy,
                        ModifiedDate = x.p.ModifiedDate,
                        ModifiedBy = x.p.ModifiedBy,
                        ProductCategoryId = x.p.ProductCategoryId,
                        ProductCategoryName = x.pc.Name
                    }).ToListAsync();
                    return data;
                }
                else
                {
                    throw new DentalManagementException($"Không có sản phẩm cho category: {request.ProductCategoryId}");
                }
                
            }
            else
            {
                throw new DentalManagementException($"Không hợp lệ");
            }
        }

        public async Task<ProductViewModel> GetById(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if(product == null)
            {
                throw new DentalManagementException($"Không tìm thấy sản phẩm có id: {productId}");
            }
            else
            {
                var productViewModel = new ProductViewModel()
                {
                    Id = product.Id,
                    Name = product.Name,
                    UnitPrice = product.UnitPrice,
                    CreatedDate = product.CreatedDate,
                    CreatedBy = product.CreatedBy,
                    ModifiedDate = product.ModifiedDate,
                    ModifiedBy = product.ModifiedBy,
                    ProductCategoryId = product.ProductCategoryId
                };
                return productViewModel;
            }
        }
    }
}
