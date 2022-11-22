using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Invoices
{
    public class InvoiceDetailViewModel
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal ItemDiscountPercent { get; set; }
        public decimal ItemDiscountAmount { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal Quantity { get; set; }
    }
}
