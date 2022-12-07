using DentalManagement.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Customers
{
    public class CustomerViewModel
    {
        [DisplayName("Mã khách hàng")]
        public int Id { get; set; }
        [DisplayName("Họ và tên")]
        public string FullName { get; set; }
        [DisplayName("Giới tính")]
        public Gender Gender { get; set; }
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
        [DisplayName("Trạng thái")]
        public Status Status { get; set; }
        [DisplayName("Ghi chú")]
        public string Description { get; set; }
        [DisplayName("Ngày tạo")]
        public DateTime? CreatedDate { get; set; }
        [DisplayName("Được tạo bởi")]
        public string CreatedBy { get; set; }
        [DisplayName("Ngày chỉnh sửa")]
        public DateTime? ModifiedDate { get; set; }
        [DisplayName("Được chỉnh sửa bởi")]
        public string ModifiedBy { get; set; }
    }
}
