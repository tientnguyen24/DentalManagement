using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceLines;

namespace DentalManagement.Application.Catalog.Invoices
{
    public interface IInvoiceService
    {
        Task<ApiResult<int>> Create(InvoiceCreateRequest request);
        Task<int> Update(InvoiceUpdateRequest request);
        Task<int> Delete(InvoiceDeleteRequest request);
        Task<bool> UpdateStatus(int invoiceId, Status updatedStatus);
        Task<List<InvoiceViewModel>> GetAll();
        Task<InvoiceViewModel> GetById(int invoiceId);
        Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request);
        Task<List<InvoiceViewModel>> GetAllByCustomerId(GetInvoiceByCustomerIdRequest request);
        Task<List<InvoiceLineViewModel>> GetDetailByInvoiceId(int? invoiceId);
    }
}
