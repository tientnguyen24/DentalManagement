using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DentalManagement.Data.Entities
{
    public class ProductCategory
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }

        public List<Product> Products { get; set; }
    }
}
