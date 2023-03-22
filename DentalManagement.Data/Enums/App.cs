using System.ComponentModel.DataAnnotations;

namespace DentalManagement.Data.Enums
{
    public enum Gender
    {
        [Display(Name = "Nam")] Male = 0,
        [Display(Name = "Nữ")] Female = 1,
        [Display(Name = "Khác")] Other = 2
    }

    public enum Status
    {
        [Display(Name = "Hoạt động")] Active = 0,
        [Display(Name = "Tạm khóa")] Inactive = 1,
        [Display(Name = "Đang thực hiện")] Processing = 2,
        [Display(Name = "Đã hủy")] Cancelled = 3,
        [Display(Name = "Đã hoàn thành")] Completed = 4
    }

    public enum PaymentStatus
    {
        [Display(Name = "Đang thực hiện")] Processing = 0,
        [Display(Name = "Đã hủy")] Cancelled = 1,
        [Display(Name = "Đã hoàn thành")] Completed = 2
    }
}