using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using DentalManagement.ViewModels.Catalog.Customers;

namespace DentalManagement.Application.Catalog.Invoices
{
    public interface IInvoiceService
    {
        Task<ApiResult<int>> Create(InvoiceCreateRequest request);
        Task<int> Update(InvoiceUpdateRequest request);
        Task<int> Delete(int id);
        Task<bool> UpdateStatus(int id, PaymentStatus updatedPaymentStatus);
        Task<List<InvoiceViewModel>> GetAll();
        Task<InvoiceViewModel> GetById(int id);
        Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request);
        Task<List<InvoiceViewModel>> GetAllByCustomerId(int id);
        Task<List<InvoiceDetailViewModel>> GetInvoiceDetailsByInvoiceId(int id);
    }
}
