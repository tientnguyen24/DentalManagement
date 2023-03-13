using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Entities
{
    public class Invoice
    {
        public int Id { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal TotalDiscountPercent { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalInvoiceAmount { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Description { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public decimal PrepaymentAmount { get; set; }
    }
}
