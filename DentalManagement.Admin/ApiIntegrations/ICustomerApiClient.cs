using DentalManagement.Application.Catalog.Customers.ViewModels;
using DentalManagement.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.ApiIntegrations
{
    public interface ICustomerApiClient
    {
        Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request);
    }
}
