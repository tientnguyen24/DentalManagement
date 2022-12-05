using DentalManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

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

        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }

        [DisplayName("% giảm giá")]
        public decimal ItemDiscountPercent { get; set; }

        [DisplayName("Số tiền giảm")]
        public decimal ItemDiscountAmount { get; set; }

        [DisplayName("Thành tiền")]
        public decimal ItemAmount { get; set; }

        [DisplayName("Số lượng")]
        public decimal Quantity { get; set; }
    }
}
