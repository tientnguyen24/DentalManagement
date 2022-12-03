using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Products
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string CreatedBy { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
