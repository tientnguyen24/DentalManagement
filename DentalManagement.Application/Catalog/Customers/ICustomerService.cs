using DentalManagement.Application.Catalog.Customers.ViewModels;
using DentalManagement.Application.Common;
using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.Application.Catalog.Customers
{
    public interface ICustomerService
    {
        Task<int> Create(CustomerCreateRequest request);
        Task<int> Update(CustomerUpdateRequest request);
        Task<int> Delete(CustomerDeleteRequest request);
        Task<bool> UpdateStatus(int customerId, Status updatedStatus);
        Task<List<CustomerViewModel>> GetAll();
        Task<CustomerViewModel> GetById(int customerId);
        Task<PagedResult<CustomerViewModel>> GetAllPaging(GetCustomerPagingRequest request);
    }
}
