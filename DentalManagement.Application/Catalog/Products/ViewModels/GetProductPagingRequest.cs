using DentalManagement.Application.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Products.ViewModels
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
    }
}
