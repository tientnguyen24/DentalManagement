using DentalManagement.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Customers.ViewModels
{
    public class GetCustomerPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
