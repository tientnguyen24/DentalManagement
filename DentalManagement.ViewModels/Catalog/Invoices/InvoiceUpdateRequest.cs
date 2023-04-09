using DentalManagement.Data.Entities;
using DentalManagement.Data.Enums;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Invoices
{
    public class InvoiceUpdateRequest
    {
        public int Id { get; set; }
        public decimal TotalDiscountPercent { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalInvoiceAmount { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Description { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public decimal PrepaymentAmount { get; set; }
        public decimal RemainAmount { get; set; }
    }
}
