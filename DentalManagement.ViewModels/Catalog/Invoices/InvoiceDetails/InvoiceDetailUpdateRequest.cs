using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails
{
    public class InvoiceDetailUpdateRequest
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public Status Status { get; set; }
    }
}
