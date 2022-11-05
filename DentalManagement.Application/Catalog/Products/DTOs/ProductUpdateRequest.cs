using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Products.DTOs
{
    public class ProductUpdateRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
    }
}
