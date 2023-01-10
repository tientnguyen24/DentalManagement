using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Invoices
{
    public class GetInvoicePagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
