using DentalManagement.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.ViewModels.Catalog.Customers
{
    public class GetCustomerPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
