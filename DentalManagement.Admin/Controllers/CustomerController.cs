using DentalManagement.Admin.ApiIntegrations;
using DentalManagement.ViewModels.Catalog.Customers;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
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
    public class CustomerController : BaseController
    {
        private readonly ICustomerApiClient _customerApiClient;
        private readonly IConfiguration _config;
        private readonly IValidator<CustomerCreateRequest> _validator;
        public CustomerController(ICustomerApiClient customerApiClient, IConfiguration config, IValidator<CustomerCreateRequest> validator)
        {
            _customerApiClient = customerApiClient;
            _config = config;
            _validator = validator;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            var request = new GetCustomerPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _customerApiClient.GetAllPaging(request);
            //ViewBag.Keyword = keyword;
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int customerId)
        {
            var data = await _customerApiClient.GetById(customerId);
            return View(data);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateRequest request)
        {
            ValidationResult result = await _validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View("Create", request);
            }
            var data = await _customerApiClient.Create(request);
            if (!data)
            {
                return View(request);
            }
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(CustomerUpdateRequest request)
        {
/*            ValidationResult result = await _validator.ValidateAsync(request);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View("Update", request);
            }*/
            var data = await _customerApiClient.Update(request);
            if (data == null)
            {
                return View(request);
            }
            return RedirectToAction("Index");
        }
    }
}
