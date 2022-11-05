using DentalManagement.Application.CommonDTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace DentalManagement.Application.Catalog.Products.DTOs
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { get; set; }
        public List<int> ProductCategoryIds { get; set; }
    }
}
