using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string ProductCategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
