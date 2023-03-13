using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.Utilities.Constants;
using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using DentalManagement.ViewModels.Catalog.Products;
using DentalManagement.ViewModels.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Controllers
{
    [Authorize]
    public class InvoiceController : BaseController
    {
        private readonly IInvoiceApiClient _invoiceApiClient;
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        public InvoiceController(IInvoiceApiClient invoiceApiClient, IProductApiClient productApiClient,IConfiguration configuration)
        {
            _invoiceApiClient = invoiceApiClient;
            _productApiClient = productApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            ViewBag.Keyword = keyword;
            var request = new GetInvoicePagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _invoiceApiClient.GetAllPaging(request);
            return View(data.ResultObject);
        }
    }
}
