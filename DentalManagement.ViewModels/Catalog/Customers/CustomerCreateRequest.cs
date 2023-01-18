using DentalManagement.Data.Enums;
using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Customers
{
    public class CustomerCreateRequest
    {
        [DisplayName("Họ và tên")]
        public string FullName { get; set; }

        [DisplayName("Giới tính")]
        public Gender? Gender { get; set; }

        [DisplayName("Ngày sinh")]
        public DateTime? BirthDay { get; set; }

        [DisplayName("Địa chỉ thường trú")]
        public string Address { get; set; }

        [DisplayName("Số điện thoại")]
        public string PhoneNumber { get; set; }

        [DisplayName("Địa chỉ Email")]
        public string EmailAddress { get; set; }

        [DisplayName("Số CMND/CCCD")]
        public string IdentifyCard { get; set; }

        [DisplayName("Ghi chú")]
        public string Description { get; set; }
    }
}
