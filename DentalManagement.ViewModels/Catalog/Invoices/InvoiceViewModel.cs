using DentalManagement.Data.Entities;
using DentalManagement.Data.Enums;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceLines;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.ViewModels.Catalog.Invoices
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal TotalDiscountPercent { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalInvoiceAmount { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public Status Status { get; set; }
        public Task<List<InvoiceLineViewModel>> InvoiceDetails { get; set; }
    }
}
