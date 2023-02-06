using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Data.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Gender? Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdentifyCard { get; set; }
        public Status Status { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public List<Invoice> Invoices { get; set; }
        public decimal CurrentBalance { get; set; }
    }
}
