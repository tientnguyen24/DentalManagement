using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.ApiIntegrations
{
    public interface ICustomerApiClient
    {
        Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request);
        Task<bool> Create(CustomerCreateRequest request);
    }
}
