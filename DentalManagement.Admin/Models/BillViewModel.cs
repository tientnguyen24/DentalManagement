using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Models
{
    public class BillViewModel
    {
        public List<BillItemViewModel> BillItemViewModels { get; set; }
        public ProductViewModel ProductViewModel { get; set; }
        public CustomerViewModel CustomerViewModel { get; set; }
    }
}
