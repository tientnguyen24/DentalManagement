using DentalManagement.Application.Catalog.Products.DTOs;
using DentalManagement.Application.CommonDTO;
using DentalManagement.Data.EF;
using DentalManagement.Data.Entities;
using DentalManagement.Utillities.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var productCategories = await (from pc in _context.ProductCategories
                                           join p in _context.Products on pc.Id equals p.ProductCategoryId
                                           select pc.Name).ToListAsync();
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
                ProductCategories = productCategories
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
            if(request.ProductCategoryIds.Count > 0)
            {
                query = query.Where(x=>request.ProductCategoryIds.Contains(x.p.ProductCategoryId));
            }
            //paging
            int totalRow = await query.CountAsync();
            var productCategories = await (from pc in _context.ProductCategories
                                           join p in _context.Products on pc.Id equals p.ProductCategoryId
                                           select pc.Name).ToListAsync();

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
                ProductCategories = productCategories
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
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            if(product == null)
            {
                throw new DentalManagementException($"Không tìm thấy sản phẩm: {productId}");
            }
            _context.Products.Remove(product);
            return await _context.SaveChangesAsync();
        }

        public async Task<PagedResult<ProductViewModel>> GetAllByProductCategoryId(GetProductPagingRequest request)
        {
            //select product record
            var query = from pc in _context.ProductCategories
                        join p in _context.Products on pc.Id equals p.ProductCategoryId
                        select new { p, pc };
            var productCategories = await (from pc in _context.ProductCategories
                                           join p in _context.Products on pc.Id equals p.ProductCategoryId
                                           select pc.Name).ToListAsync();
            //filter product
            if (request.ProductCategoryIds.Count > 0)
            {
                query = query.Where(x => request.ProductCategoryIds.Contains(x.p.ProductCategoryId));
            }
            //paging
            int totalRow = await query.CountAsync();

            var data = await query.Skip((request.PageIndex - 1) * request.PageSize).Take(request.PageSize).Select(x => new ProductViewModel()
            {
                Id = x.p.Id,
                Name = x.p.Name,
                UnitPrice = x.p.UnitPrice,
                CreatedDate = x.p.CreatedDate,
                CreatedBy = x.p.CreatedBy,
                ModifiedDate = x.p.ModifiedDate,
                ModifiedBy = x.p.ModifiedBy,
                ProductCategoryId = x.p.ProductCategoryId,
                ProductCategories = productCategories
            }).ToListAsync();
            //select and projection
            var pagedResult = new PagedResult<ProductViewModel>()
            {
                TotalRecord = totalRow,
                Items = data,
            };
            return pagedResult;
        }

        public async Task<ProductViewModel> GetById(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            var productCategories = await (from pc in _context.ProductCategories
                                      join p in _context.Products on pc.Id equals p.ProductCategoryId
                                      where p.Id == productId
                                      select pc.Name).ToListAsync();
            var productViewModel = new ProductViewModel()
            {
                Id = product.Id,
                Name = product.Name,
                UnitPrice = product.UnitPrice,
                CreatedDate = product.CreatedDate,
                CreatedBy = product.CreatedBy,
                ModifiedDate = product.ModifiedDate,
                ModifiedBy = product.ModifiedBy,
                ProductCategoryId = product.ProductCategoryId,
                ProductCategories = productCategories
            };
            return productViewModel;
        }
    }
}
