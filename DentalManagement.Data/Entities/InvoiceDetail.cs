using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Entities
{
    public class InvoiceDetail
    {
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public decimal ItemDiscountPercent { get; set; }
        public decimal ItemDiscountAmount { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal Quantity { get; set; }
        public Invoice Invoice { get; set; }
        public Product Product { get; set; }
    }
}
