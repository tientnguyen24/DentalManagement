using DentalManagement.ViewModels.Catalog.Products;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.ApiIntegration.ApiIntegrations
{
    public interface IProductApiClient
    {
        Task<List<ProductViewModel>> GetAll();
        Task<PagedResult<ProductViewModel>> GetAllPaging(GetProductPagingRequest request);
        Task<ApiResult<ProductViewModel>> GetById(int id);
    }
}
