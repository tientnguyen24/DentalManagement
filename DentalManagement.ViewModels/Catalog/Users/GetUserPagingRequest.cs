﻿using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Users
{
    public class GetUserPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
