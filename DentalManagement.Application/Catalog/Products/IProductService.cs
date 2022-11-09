using DentalManagement.Application.Catalog.Products.ViewModels;
using DentalManagement.Application.Common;
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
        Task<int> Delete(ProductDeleteRequest request);
        Task<List<ProductViewModel>> GetAll();
        Task<ProductViewModel> GetById(int productId);
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        Task<List<ProductViewModel>> GetAllByProductCategoryId(GetProductByCategoryIdRequest request);
    }
}
