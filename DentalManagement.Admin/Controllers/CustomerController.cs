using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.ViewModels.Catalog.Customers;
using FluentValidation;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Controllers
{
    [Authorize]
    public class CustomerController : BaseController
    {
        private readonly ICustomerApiClient _customerApiClient;
        private readonly IConfiguration _configuration;
        private readonly IValidator<CustomerCreateRequest> _customerCreateRequestValidator;
        private readonly IValidator<CustomerUpdateRequest> _customerUpdateRequestValidator;

        public CustomerController(ICustomerApiClient customerApiClient, IConfiguration configuration, IValidator<CustomerCreateRequest> customerCreateRequestValidator, IValidator<CustomerUpdateRequest> customerUpdateRequestValidator)
        {
            _customerApiClient = customerApiClient;
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

    }
}