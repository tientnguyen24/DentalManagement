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
        public decimal ItemDiscountPercent { get; set; }
        public decimal ItemDiscountAmount { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? CompletedDate { get; set; }
        public Status Status { get; set; }
    }
}
