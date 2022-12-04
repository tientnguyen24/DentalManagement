using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.ApiIntegrations
{
    public interface IInvoiceApiClient
    {
        Task<ApiResult<PagedResult<InvoiceViewModel>>> GetAllPaging(GetInvoicePagingRequest request);
        Task<ApiResult<bool>> Create(InvoiceCreateRequest request);
    }
}
