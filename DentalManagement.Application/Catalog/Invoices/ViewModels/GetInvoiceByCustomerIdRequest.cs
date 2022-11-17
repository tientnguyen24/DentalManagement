using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Invoices.ViewModels
{
    public class GetInvoiceByCustomerIdRequest
    {
        public int? CustomerId { get; set; }
    }
}
