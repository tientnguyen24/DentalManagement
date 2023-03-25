using DentalManagement.Data.Enums;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.ApiIntegration.ApiIntegrations
{
    public interface IInvoiceApiClient
    {
        Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request);
        Task<ApiResult<InvoiceViewModel>> GetbyId(int id);
        Task<ApiResult<bool>> Create(InvoiceCreateRequest request);
        Task<ApiResult<bool>> UpdateInvoiceDetailStatus(int invoiceId, int productId, Status updatedInvoiceDetailStatus);
    }
}
