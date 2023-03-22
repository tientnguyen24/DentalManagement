using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails
{
    public class InvoiceDetailCreateRequest
    {
        public int ProductId { get; set; }
        public decimal ItemDiscountPercent { get; set; }
        public decimal ItemDiscountAmount { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal Quantity { get; set; }
        public DateTime CompletedDate { get; set; }
        public Status Status { get; set; }
    }
}
