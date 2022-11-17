using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Products.ViewModels
{
    public class ProductCreateRequest
    {
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public string CreatedBy { get; set; }
        public int ProductCategoryId { get; set; }
    }
}
