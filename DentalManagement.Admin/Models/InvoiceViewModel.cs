using DentalManagement.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Models
{
    public class InvoiceViewModel
    {
        public List<ProductViewModel> Products { get; set; }
    }
}
