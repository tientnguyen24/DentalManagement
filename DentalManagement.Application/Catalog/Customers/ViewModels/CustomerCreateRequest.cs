using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Customers.ViewModels
{
    public class CustomerCreateRequest
    {
        public string FullName { get; set; }
        public Gender Gender { get; set; }
        public DateTime? BirthDay { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdentifyCard { get; set; }
        public string Description { get; set; }
    }
}
