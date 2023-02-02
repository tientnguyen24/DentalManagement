using DentalManagement.Admin.Models;
using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.Utilities.Constants;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceLines;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DentalManagement.Admin.Controllers
{
    [Authorize]
    public class BillController : BaseController
    {
        private readonly IProductApiClient _productApiClient;
        private readonly ICustomerApiClient _customerApiClient;
        private readonly IInvoiceApiClient _invoiceApiClient;
        public BillController(IProductApiClient productApiClient, ICustomerApiClient customerApiClient, IInvoiceApiClient invoiceApiClient)
        {
            _productApiClient = productApiClient;
            _customerApiClient = customerApiClient;
            _invoiceApiClient = invoiceApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillItemSession);
            List<BillItemViewModel> currentBillItem = new List<BillItemViewModel>();
            if (session != null)
                currentBillItem = JsonConvert.DeserializeObject<List<BillItemViewModel>>(session);
            return Ok(currentBillItem);
        }

        [HttpGet]
        public IActionResult GetListSummary()
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillSummarySession);
            BillSummaryViewModel currentBillSummary = new BillSummaryViewModel();
            if (session != null)
            {
                currentBillSummary = JsonConvert.DeserializeObject<BillSummaryViewModel>(session);
            }
            else
            {
                currentBillSummary = new BillSummaryViewModel()
                {
                    CreatedDate = DateTime.Now,
                    TotalDiscountAmount = 0,
                    Description = "",
                    PrepaymentAmount = 0
                };
                HttpContext.Session.SetString(SystemConstants.BillSummarySession, JsonConvert.SerializeObject(currentBillSummary));
            }
            return Ok(currentBillSummary);
        }

        [HttpGet]
        public async Task<IActionResult> GetListProducts()
        {
            var products = await _productApiClient.GetAll();
            List<ProductViewModel> currentProduct = new List<ProductViewModel>();
            foreach (var item in products)
            {
                var productItem = new ProductViewModel()
                {
                    ProductId = item.Id,
                    ProductCategoryName = item.ProductCategoryName,
                    ProductName = item.Name,
                    UnitPrice = item.UnitPrice
                };
                currentProduct.Add(productItem);
            }
            return Ok(currentProduct);
        }

        [HttpGet]
        public async Task<IActionResult> GetListCustomers()
        {
            var customers = await _customerApiClient.GetAll();
            List<CustomerViewModel> currentCustomer = new List<CustomerViewModel>();
            foreach (var item in customers)
            {
                var customerItem = new CustomerViewModel()
                {
                    CustomerId = item.Id,
                    FullName = item.FullName,
                    Gender = (int)item.Gender,
                    BirthDay = item.BirthDay,
                    Address = item.Address,
                    PhoneNumber = item.PhoneNumber,
                    Description = item.Description,
                    CurrentBalance = item.CurrentBalance
                };
                currentCustomer.Add(customerItem);
            }
            return Ok(currentCustomer);
        }

        [HttpGet]
        public IActionResult GetCustomer()
        {
            var session = HttpContext.Session.GetString(SystemConstants.CustomerSession);
            CustomerViewModel currentCustomer = new CustomerViewModel();
            if (session != null)
                currentCustomer = JsonConvert.DeserializeObject<CustomerViewModel>(session);
            return Ok(JsonConvert.SerializeObject(currentCustomer));
        }
        public async Task<IActionResult> AddCustomerToBill(int id)
        {
            var customer = await _customerApiClient.GetById(id);
            var currentCustomer = new CustomerViewModel()
            {
                CustomerId = customer.ResultObject.Id,
                FullName = customer.ResultObject.FullName,
                Gender = (int)customer.ResultObject.Gender,
                BirthDay = customer.ResultObject.BirthDay,
                Address = customer.ResultObject.Address,
                PhoneNumber = customer.ResultObject.PhoneNumber,
                Description = customer.ResultObject.Description
            };
            HttpContext.Session.SetString(SystemConstants.CustomerSession, JsonConvert.SerializeObject(currentCustomer));
            return Ok(JsonConvert.SerializeObject(currentCustomer));
        }
        public async Task<IActionResult> AddProductToBill(int id)
        {
            var product = await _productApiClient.GetById(id);
            var session = HttpContext.Session.GetString(SystemConstants.BillItemSession);
            List<BillItemViewModel> currentBillItem = new List<BillItemViewModel>();
            if (session != null)
                currentBillItem = JsonConvert.DeserializeObject<List<BillItemViewModel>>(session);
            int quantity = 1;
            if (currentBillItem.Any(x => x.ProductId == id))
            {
                quantity = currentBillItem.First(x => x.ProductId == id).Quantity + 1;
                var currentItem = currentBillItem.Single(x => x.ProductId == id);
                currentBillItem.Remove(currentItem);
            }
            var billItem = new BillItemViewModel()
            {
                ProductId = id,
                ProductName = product.ResultObject.Name,
                UnitPrice = product.ResultObject.UnitPrice,
                Quantity = quantity
            };
            currentBillItem.Add(billItem);
            HttpContext.Session.SetString(SystemConstants.BillItemSession, JsonConvert.SerializeObject(currentBillItem));
            return Ok(currentBillItem);
        }

        public IActionResult UpdateQuantity(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillItemSession);
            List<BillItemViewModel> currentBillItem = new List<BillItemViewModel>();
            if (session != null)
                currentBillItem = JsonConvert.DeserializeObject<List<BillItemViewModel>>(session);
            foreach (var item in currentBillItem)
            {
                if (item.ProductId == id)
                {
                    if (quantity == 0)
                    {
                        currentBillItem.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }
            HttpContext.Session.SetString(SystemConstants.BillItemSession, JsonConvert.SerializeObject(currentBillItem));
            return Ok(currentBillItem);
        }

        public IActionResult UpdateDiscount(decimal totalInvoiceAmount)
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillSummarySession);
            BillSummaryViewModel currentBillSummary = new BillSummaryViewModel();
            if (session != null)
                currentBillSummary = JsonConvert.DeserializeObject<BillSummaryViewModel>(session);
            currentBillSummary = new BillSummaryViewModel()
            {
                TotalDiscountAmount = totalInvoiceAmount,
            };
            HttpContext.Session.SetString(SystemConstants.BillSummarySession, JsonConvert.SerializeObject(currentBillSummary));
            return Ok(currentBillSummary);
        }

        public IActionResult UpdatePrepayment(decimal prepaymentAmount)
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillSummarySession);
            BillSummaryViewModel currentBillSummary = new BillSummaryViewModel();
            if (session != null)
                currentBillSummary = JsonConvert.DeserializeObject<BillSummaryViewModel>(session);
            currentBillSummary = new BillSummaryViewModel()
            {
                PrepaymentAmount = prepaymentAmount,
            };
            HttpContext.Session.SetString(SystemConstants.BillSummarySession, JsonConvert.SerializeObject(currentBillSummary));
            return Ok(currentBillSummary);
        }

        public IActionResult UpdateDescription(string description)
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillSummarySession);
            BillSummaryViewModel currentBillSummary = new BillSummaryViewModel();
            if (session != null)
                currentBillSummary = JsonConvert.DeserializeObject<BillSummaryViewModel>(session);
            currentBillSummary = new BillSummaryViewModel()
            {
                Description = description,
            };
            HttpContext.Session.SetString(SystemConstants.BillSummarySession, JsonConvert.SerializeObject(currentBillSummary));
            return Ok(currentBillSummary);
        }

        public IActionResult Payment()
        {
            var model = GetBillViewModel();
            if (model.BillItemViewModels.Count == 0 && model.CustomerViewModel.CustomerId == 0)
            {
                TempData["errorMsg"] = "Thiếu thông tin";
                return View("Index");
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Payment(BillViewModel request)
        {
            var model = GetBillViewModel();
            var invoiceLines = new List<InvoiceLineCreateRequest>();
            foreach (var item in model.BillItemViewModels)
            {
                invoiceLines.Add(new InvoiceLineCreateRequest()
                {
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    ItemAmount = item.UnitPrice * item.Quantity
                });
            }
            var invoiceCreateRequest = new InvoiceCreateRequest()
            {
                CustomerId = model.CustomerViewModel.CustomerId,
                CreatedDate = DateTime.Now,
                CreatedBy = User.Identity.Name,
                TotalInvoiceAmount = model.BillSummaryViewModel.TotalInvoiceAmount,
                PrepaymentAmount = model.BillSummaryViewModel.PrepaymentAmount,
                InvoiceLines = invoiceLines
            };

            var data = await _invoiceApiClient.Create(invoiceCreateRequest);
            if (!data.IsSuccessed)
            {
                TempData["errorMsg"] = "Thiếu thông tin";
                return View(GetBillViewModel());
            }
            HttpContext.Session.Remove(SystemConstants.BillItemSession);
            HttpContext.Session.Remove(SystemConstants.BillSummarySession);
            HttpContext.Session.Remove(SystemConstants.CustomerSession);
            TempData["successMsg"] = "Thành công";
            return RedirectToAction("Index");
        }

        private BillViewModel GetBillViewModel()
        {
            var billItemSession = HttpContext.Session.GetString(SystemConstants.BillItemSession);
            List<BillItemViewModel> currentBillItem = new List<BillItemViewModel>();
            var customerSession = HttpContext.Session.GetString(SystemConstants.CustomerSession);
            CustomerViewModel currentCustomer = new CustomerViewModel();
            var billSummarySession = HttpContext.Session.GetString(SystemConstants.BillSummarySession);
            BillSummaryViewModel currentBillSummary = new BillSummaryViewModel();
            if (billItemSession != null && customerSession != null && billSummarySession != null)
            {
                currentBillItem = JsonConvert.DeserializeObject<List<BillItemViewModel>>(billItemSession);
                currentCustomer = JsonConvert.DeserializeObject<CustomerViewModel>(customerSession);
                currentBillSummary = JsonConvert.DeserializeObject<BillSummaryViewModel>(billSummarySession);
            }

            var billViewModel = new BillViewModel()
            {
                BillItemViewModels = currentBillItem,
                CustomerViewModel = currentCustomer,
                BillSummaryViewModel = currentBillSummary
            };
            return billViewModel;
        }
    }
}
