using DentalManagement.Data.Entities;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.ViewModels.Catalog.Invoices
{
    public class InvoiceCreateRequest
    {
        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }
        
        public decimal TotalDiscountPercent { get; set; }

        public decimal TotalDiscountAmount { get; set; }

        public decimal TotalInvoiceAmount { get; set; }

        public int CustomerId { get; set; }

        public string Description { get; set; }

        public decimal PrepaymentAmount { get; set; }

        public List<InvoiceDetailCreateRequest> InvoiceDetails { get; set; }
    }
}
