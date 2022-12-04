using DentalManagement.ApiIntegrations;
using DentalManagement.ViewModels.Catalog.Invoices;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Controllers
{
    public class InvoiceController : BaseController
    {
        private readonly IInvoiceApiClient _invoiceApiClient;
        private readonly IConfiguration _configuration;
        public InvoiceController(IInvoiceApiClient invoiceApiClient, IConfiguration configuration)
        {
            _invoiceApiClient = invoiceApiClient;
            _configuration = configuration;
        }
        public async Task<IActionResult> Index(DateTime? invoiceDate, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetInvoicePagingRequest()
            {
                InvoiceDate = invoiceDate,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _invoiceApiClient.GetAllPaging(request);
            ViewBag.InvoiceDate = invoiceDate;
            return View(data.ResultObject);
        }
    }
}
