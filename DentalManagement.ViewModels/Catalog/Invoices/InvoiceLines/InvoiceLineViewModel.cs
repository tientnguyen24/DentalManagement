using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Invoices.InvoiceLines
{
    public class InvoiceLineViewModel
    {
        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }

        [DisplayName("Đơn giá")]
        public decimal UnitPrice { get; set; }

        [DisplayName("Mã danh mục")]
        public int ProductCategoryId { get; set; }

        [DisplayName("Tên danh mục")]
        public string ProductCategoryName { get; set; }

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
