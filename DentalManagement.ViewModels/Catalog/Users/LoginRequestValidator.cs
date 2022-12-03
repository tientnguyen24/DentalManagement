﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Users
{
    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Tên tài khoản không được để trống");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Mật khẩu không được để trống");
        }
    }
}
