using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Utilities.Constants
{
    public static class SystemConstants
    {
        public const string MainConnectionString = "DentalManagementDb";
        public const string BillSession = "BillSession";
        public static class AppSettings
        {
            public const string Token = "Token";
            public const string BaseAddress = "BaseAddress";
        }

        public static class AppErrorMessage
        {
            public const string Create = "Tạo mới không thành công";
            public const string Update = "Cập nhập không thành công";
            public const string Delete = "Xoá không thành công";
            public const string Authenticate = "Đăng nhập không thành công";
        }

        public static class AppSuccessMessage
        {
            public const string Create = "Tạo mới thành công";
            public const string Update = "Cập nhập thành công";
            public const string Delete = "Xoá thành công";
            public const string Authenticate = "Đăng nhập thành công";
        }
    }
}
