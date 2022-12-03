﻿using System;
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
    }
}
