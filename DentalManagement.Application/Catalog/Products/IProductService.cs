using DentalManagement.ViewModels.Catalog.Products;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Application.Catalog.Products
{
    public interface IProductService
    {
        Task<int> Create(ProductCreateRequest request);
        Task<int> Update(ProductUpdateRequest request);
        Task<int> Delete(int productId);
        Task<bool> UpdateStatus(int productId, Status updatedStatus);
        Task<List<ProductViewModel>> GetAll();
        Task<ApiResult<ProductViewModel>> GetById(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        Task<List<ProductViewModel>> GetAllByProductCategoryId(GetProductByCategoryIdRequest request);
    }
}
