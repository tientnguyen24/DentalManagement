using DentalManagement.Admin.ApiIntegrations;
using DentalManagement.ViewModels.Catalog.Customers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Controllers
{
    [Authorize]
    public class CustomerController : Controller
    {
        private readonly ICustomerApiClient _customerApiClient;
        private readonly IConfiguration _config;
        public CustomerController(ICustomerApiClient customerApiClient, IConfiguration config)
        {
            _customerApiClient = customerApiClient;
            _config = config;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var sessions = HttpContext.Session.GetString("Token");
            var request = new GetCustomerPagingRequest()
            {
                BearerToken = sessions,
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _customerApiClient.GetAllPaging(request);
            ViewBag.Keyword = keyword;

            return View(data);
        }
    }
}
