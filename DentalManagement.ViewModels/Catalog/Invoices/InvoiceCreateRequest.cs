using DentalManagement.Data.Entities;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceLines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.ViewModels.Catalog.Invoices
{
    public class InvoiceCreateRequest
    {
        [DisplayName("Ngày lập hoá đơn")]
        public DateTime CreatedDate { get; set; }

        [DisplayName("Được tạo bởi")]
        public string CreatedBy { get; set; }
        
        [DisplayName("Tổng % giảm giá")]
        public decimal TotalDiscountPercent { get; set; }

        [DisplayName("Tổng số tiền giảm giá")]
        public decimal TotalDiscountAmount { get; set; }

        [DisplayName("Tổng thành tiền")]
        public decimal TotalInvoiceAmount { get; set; }

        [DisplayName("Mã khách hàng")]
        public int CustomerId { get; set; }

        [DisplayName("Ghi chú")]
        public string Description { get; set; }

        public List<InvoiceLineCreateRequest> InvoiceLines { get; set; }
    }
}
