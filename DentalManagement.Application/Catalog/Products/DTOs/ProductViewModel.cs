using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Products.DTOs
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public int ProductCategoryId { get; set; }
        public List<string> ProductCategories { get; set; } = new List<string>();
    }
}
