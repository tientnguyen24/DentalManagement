using DentalManagement.Data.EF;
using DentalManagement.Data.Entities;
using DentalManagement.ViewModels.Catalog.ProductCategories;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Application.Catalog.ProductCategories
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly DentalManagementDbContext _context;
        public ProductCategoryService(DentalManagementDbContext context)
        {
            _context = context;
        }

        public async Task<ApiResult<int>> Create(ProductCategoryCreateRequest request)
        {
            var productCategory = new ProductCategory()
            {
                Name = request.Name,
                CreatedDate = DateTime.Now,
                CreatedBy = request.CreatedBy
            };
            _context.ProductCategories.Add(productCategory);
            await _context.SaveChangesAsync();
            return new ApiSuccessResult<int>(productCategory.Id);
        }
    }
}
