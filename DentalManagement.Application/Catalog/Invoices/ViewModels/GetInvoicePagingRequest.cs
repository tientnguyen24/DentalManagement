using DentalManagement.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Invoices.ViewModels
{
    public class GetInvoicePagingRequest : PagingRequestBase
    {
        public DateTime? InvoiceDate { get; set; }
    }
}
