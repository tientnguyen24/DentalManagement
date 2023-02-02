using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Models
{
    public class BillSummaryViewModel
    {
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public decimal TotalDiscountPercent { get; set; }
        public decimal TotalDiscountAmount { get; set; }
        public decimal TotalInvoiceAmount { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Description { get; set; }
        public decimal PrepaymentAmount { get; set; }
    }
}
