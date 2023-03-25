using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T data)
        {
            IsSuccessed = true;
            Data = data;
        }
        public ApiSuccessResult()
        {
            IsSuccessed = true;
        }
        public ApiSuccessResult(string message)
        {
            IsSuccessed = true;
            Message = message;
        }
        public ApiSuccessResult(string message, T data)
        {
            IsSuccessed = true;
            Message = message;
            Data = data;
        }
    }
}
