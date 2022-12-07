using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Customers
{
    public class CustomerUpdateRequestValidator : AbstractValidator<CustomerUpdateRequest>
    {
        public CustomerUpdateRequestValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("Họ và tên không được để trống").MaximumLength(100).WithMessage("Họ và tên vượt quá ký tự cho phép");
            RuleFor(x => x.Gender).NotNull().WithMessage("Giới tính không hợp lệ");
            RuleFor(x => x.BirthDay).LessThan(DateTime.Now).WithMessage("Ngày sinh không hợp lệ");
            RuleFor(x => x.Address).NotEmpty().WithMessage("Địa chỉ thường trú không được để trống").MaximumLength(200).WithMessage("Địa chỉ thường trú vượt quá ký tự cho phép");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Số điện thoại không được để trống").MinimumLength(9).WithMessage("Số điện thoại không hợp lệ");
            RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Địa chỉ Email không hợp lệ");
            RuleFor(x => x.IdentifyCard).MinimumLength(9).WithMessage("Số CMND/CCCD không hợp lệ").MaximumLength(12).WithMessage("Số CMND/CCCD không hợp lệ");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Tiền sử bệnh vượt quá ký tự cho phép");
        }

    }
}
