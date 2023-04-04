using DentalManagement.Data.Entities;
using DentalManagement.Data.Enums;
using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace DentalManagement.ViewModels.Catalog.Invoices
{
    public class InvoiceViewModel
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal TotalDiscountPercent { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal TotalDiscountAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal TotalInvoiceAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? ModifiedDate { get; set; }

        public string ModifiedBy { get; set; }

        public string Description { get; set; }

        public PaymentStatus PaymentStatus { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal PrepaymentAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:N0}", ApplyFormatInEditMode = true)]
        public decimal RemainAmount { get; set; }
        public int CustomerId { get; set; }
        public List<InvoiceDetailViewModel> InvoiceDetailViewModels { get; set; }
    }
}
