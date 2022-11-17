using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DentalManagement.Data.Entities
{
    public class Customer
    {
        [Required]
        public int Id { get; set; }
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdentifyCard { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<Invoice> Invoices { get; set; }
    }
}
