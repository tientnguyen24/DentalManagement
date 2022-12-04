using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.ApiIntegrations
{
    public interface ICustomerApiClient
    {
        Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request);
        Task<bool> Create(CustomerCreateRequest request);
        Task<ApiResult<bool>> Update(CustomerUpdateRequest request);
        Task<ApiResult<CustomerViewModel>> GetById(int id);
    }
}
