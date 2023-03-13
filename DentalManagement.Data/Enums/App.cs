using System.ComponentModel.DataAnnotations;

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

    public enum PaymentStatus
    {
        [Display(Name = "Chưa hoàn thành")] Processing,
        [Display(Name = "Đã hủy")] Cancelled,
        [Display(Name = "Đã hoàn thành")] Completed
    }
}