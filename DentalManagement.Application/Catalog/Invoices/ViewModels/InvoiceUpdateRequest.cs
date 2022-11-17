using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Invoices.ViewModels
{
    public class InvoiceUpdateRequest
    {
        public int Id { get; set; }
        public decimal TotalDiscountPercent { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalInvoiceAmount { get; set; }
        public string ModifiedBy { get; set; }
        public string Description { get; set; }
    }
}
