using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Application.Catalog.Customers
{
    public interface ICustomerService
    {
        Task<ApiResult<int>> Create(CustomerCreateRequest request);
        Task<ApiResult<bool>> Update(CustomerUpdateRequest request);
        Task<int> Delete(int id);
        Task<bool> UpdateStatus(int id, Status updatedStatus);
        Task<List<CustomerViewModel>> GetAll();
        Task<ApiResult<CustomerViewModel>> GetById(int id);
        Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request);

    }
}
