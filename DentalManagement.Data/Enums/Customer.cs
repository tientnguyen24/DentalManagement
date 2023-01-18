using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DentalManagement.Data.Enums
{
    public enum Gender
    {
        [Display(Name = "Nam")] Male,
        [Display(Name = "Nữ")] Female,
        [Display(Name = "Khác")] Other
    }

    public enum Status
    {
        [Display(Name = "Hoạt động")] Active,
        [Display(Name = "Tạm khóa")] Inactive
    }
}
