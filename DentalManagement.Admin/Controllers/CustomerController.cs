using DentalManagement.Admin.Models;
using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.Utilities.Constants;
using DentalManagement.ViewModels.Catalog.Customers;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Controllers
{
    [Authorize]
    public class CustomerController : BaseController
    {
        private readonly ICustomerApiClient _customerApiClient;
        private readonly IProductApiClient _productApiClient;
        private readonly IConfiguration _configuration;
        private readonly IValidator<CustomerCreateRequest> _customerCreateRequestValidator;
        private readonly IValidator<CustomerUpdateRequest> _customerUpdateRequestValidator;

        public CustomerController(ICustomerApiClient customerApiClient, IProductApiClient productApiClient, IConfiguration configuration, IValidator<CustomerCreateRequest> customerCreateRequestValidator, IValidator<CustomerUpdateRequest> customerUpdateRequestValidator)
        {
            _customerApiClient = customerApiClient;
            _productApiClient = productApiClient;
            _configuration = configuration;
            _customerCreateRequestValidator = customerCreateRequestValidator;
            _customerUpdateRequestValidator = customerUpdateRequestValidator;
        }

        public async Task<IActionResult> Index(string keyword, int pageIndex = 1, int pageSize = 10)
        {
            ViewBag.Keyword = keyword;
            ViewBag.PageSize = pageSize;
            var request = new GetCustomerPagingRequest()
            {
                Keyword = keyword,
                PageIndex = pageIndex,
                PageSize = pageSize
            };
            var data = await _customerApiClient.GetAllPaging(request);
            return View(data);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var data = await _customerApiClient.GetById(id);
            return View(data.ResultObject);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerCreateRequest request)
        {
            ValidationResult result = await _customerCreateRequestValidator.ValidateAsync(request);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View("Create", request);
            }
            var data = await _customerApiClient.Create(request);
            if (!data.IsSuccessed)
            {
                return View(request);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var result = await _customerApiClient.GetById(id);
            if (result.IsSuccessed)
            {
                var customer = result.ResultObject;
                var updateRequest = new CustomerUpdateRequest()
                {
                    FullName = customer.FullName,
                    Gender = customer.Gender,
                    BirthDay = customer.BirthDay,
                    Address = customer.Address,
                    PhoneNumber = customer.PhoneNumber,
                    EmailAddress = customer.EmailAddress,
                    IdentifyCard = customer.IdentifyCard,
                    Description = customer.Description,
                };
                return View(updateRequest);
            }
            return RedirectToAction("Error", "Home");
        }

        [HttpPost]
        public async Task<IActionResult> Edit(CustomerUpdateRequest request)
        {
            ValidationResult result = await _customerUpdateRequestValidator.ValidateAsync(request);
            if (!result.IsValid)
            {
                result.AddToModelState(this.ModelState);
                return View("Edit", request);
            }
            var data = await _customerApiClient.Update(request);
            if (data == null)
            {
                return View(request);
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> GetProductList()
        {
            var productList = await _productApiClient.GetAll();
            return Ok(productList);
        }

        [HttpPost]
        public async Task<IActionResult> AddProductToMedicalInvoice(int[] productIds)
        {
            var currentInvoice = new InvoiceViewModel();
            var currentInvoiceDetail = new List<InvoiceDetailViewModel>();
            var invoiceSession = HttpContext.Session.GetString(SystemConstants.InvoiceSession);
            if (invoiceSession != null)
            {
                currentInvoice = JsonConvert.DeserializeObject<InvoiceViewModel>(invoiceSession);
            }

            foreach (var id in productIds)
            {
                var product = await _productApiClient.GetById(id);
                decimal quantity = 1;
                if (currentInvoiceDetail.Any(x => x.ProductId == id))
                {
                    quantity = currentInvoiceDetail.First(x => x.ProductId == id).Quantity + 1;
                    currentInvoiceDetail.Remove(currentInvoiceDetail.Single(x => x.ProductId == id));
                }
                var item = new InvoiceDetailViewModel()
                {
                    ProductId = id,
                    ProductName = product.ResultObject.Name,
                    UnitPrice = product.ResultObject.UnitPrice,
                    Quantity = quantity
                };
                currentInvoiceDetail.Add(item);
            }
            currentInvoice.InvoiceDetailViewModels = currentInvoiceDetail;
            HttpContext.Session.SetString(SystemConstants.InvoiceSession, JsonConvert.SerializeObject(currentInvoice));
            return Ok(currentInvoice);
        }

    }
}