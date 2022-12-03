using DentalManagement.ViewModels.Catalog.ProductCategories;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Application.Catalog.ProductCategories
{
    public interface IProductCategoryService
    {
        Task<ApiResult<int>> Create(ProductCategoryCreateRequest request);
    }
}
