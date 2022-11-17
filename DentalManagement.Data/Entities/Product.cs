using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DentalManagement.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public Status Status { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<InvoiceDetail> InvoiceDetails { get; set; }


    }
}
