using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObject)
        {
            IsSuccessed = true;
            ResultObject = resultObject;
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
        public ApiSuccessResult(string message, T resultObject)
        {
            IsSuccessed = true;
            Message = message;
            ResultObject = resultObject;
        }
    }
}
