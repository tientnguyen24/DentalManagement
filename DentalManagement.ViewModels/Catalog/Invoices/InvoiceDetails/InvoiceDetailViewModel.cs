using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails
{
    public class InvoiceDetailViewModel
    {
        [DisplayName("Mã hóa đơn")]
        public int InvoiceId { get; set; }

        [DisplayName("Mã sản phẩm")]
        public int ProductId { get; set; }

        [DisplayName("Tên sản phẩm")]
        public string ProductName { get; set; }

        [DisplayName("Đơn giá")]
        public decimal UnitPrice { get; set; }

        [DisplayName("% giảm giá")]
        public decimal ItemDiscountPercent { get; set; }

        [DisplayName("Số tiền giảm")]
        public decimal ItemDiscountAmount { get; set; }

        [DisplayName("Thành tiền")]
        public decimal ItemAmount { get; set; }

        [DisplayName("Số lượng")]
        public decimal Quantity { get; set; }

        [DisplayName("Trạng thái")]
        public Status Status { get; set; }

        [DisplayName("Ngày hoàn thành")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CompletedDate { get; set; }
    }
}
