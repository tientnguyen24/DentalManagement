using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.Utilities.Constants;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
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

        [HttpPost]
        public async Task<IActionResult> AddProductToMedicalInvoice(int[] productIds)
        {
            var currentInvoice = new InvoiceViewModel();
            var currentInvoiceDetailList = new List<InvoiceDetailViewModel>();
            var invoiceSession = HttpContext.Session.GetString(SystemConstants.InvoiceSession);
            if (invoiceSession != null)
            {
                currentInvoice = JsonConvert.DeserializeObject<InvoiceViewModel>(invoiceSession);
            }

            foreach (var id in productIds)
            {
                var product = await _productApiClient.GetById(id);
                decimal quantity = 1;
                if (currentInvoiceDetailList.Any(x => x.ProductId == id))
                {
                    quantity = currentInvoiceDetailList.First(x => x.ProductId == id).Quantity + 1;
                    currentInvoiceDetailList.Remove(currentInvoiceDetailList.Single(x => x.ProductId == id));
                }
                var item = new InvoiceDetailViewModel()
                {
                    ProductId = id,
                    ProductName = product.ResultObject.Name,
                    UnitPrice = product.ResultObject.UnitPrice,
                    Quantity = quantity,
                    ItemAmount = product.ResultObject.UnitPrice * quantity,
                };
                currentInvoiceDetailList.Add(item);
            }
            currentInvoice.InvoiceDetailViewModels = currentInvoiceDetailList;
            currentInvoice.TotalInvoiceAmount = currentInvoiceDetailList.Sum(x => x.ItemAmount);
            HttpContext.Session.SetString(SystemConstants.InvoiceSession, JsonConvert.SerializeObject(currentInvoice));
            return Ok(currentInvoice);
        }

        [HttpPost]
        public IActionResult UpdateProductQuantity(int productId, int productQuantity)
        {
            var invoiceSession = HttpContext.Session.GetString(SystemConstants.InvoiceSession);
            var currentInvoice = new InvoiceViewModel();
            if (invoiceSession != null)
            {
                currentInvoice = JsonConvert.DeserializeObject<InvoiceViewModel>(invoiceSession);
            }
            foreach (var item in currentInvoice.InvoiceDetailViewModels)
            {
                if (item.ProductId == productId)
                {
                    if (productQuantity == 0)
                    {
                        currentInvoice.InvoiceDetailViewModels.Remove(item);
                        break;
                    }
                    item.Quantity = productQuantity;
                    item.ItemAmount = item.UnitPrice * item.Quantity;
                }
            }
            currentInvoice.TotalInvoiceAmount = currentInvoice.InvoiceDetailViewModels.Sum(x => x.ItemAmount);
            HttpContext.Session.SetString(SystemConstants.InvoiceSession, JsonConvert.SerializeObject(currentInvoice));
            return Ok(currentInvoice);
        }

        [HttpPost]
        public async Task<IActionResult> Create(int customerId)
        {
            var invoiceSession = HttpContext.Session.GetString(SystemConstants.InvoiceSession);
            var currentInvoice = new InvoiceViewModel();
            if (invoiceSession != null)
            {
                currentInvoice = JsonConvert.DeserializeObject<InvoiceViewModel>(invoiceSession);
            }
            var currentInvoiceDetailList = new List<InvoiceDetailCreateRequest>();
            foreach (var item in currentInvoice.InvoiceDetailViewModels)
            {
                currentInvoiceDetailList.Add(new InvoiceDetailCreateRequest()
                {
                    ProductId = item.ProductId,
                    ItemDiscountPercent = item.ItemDiscountPercent,
                    ItemDiscountAmount = item.ItemDiscountAmount,
                    ItemAmount = item.ItemAmount,
                    Quantity = item.Quantity,
                });
            }
            var invoiceCreateRequest = new InvoiceCreateRequest()
            {
                CreatedDate = DateTime.Now,
                CreatedBy = User.Identity.Name,
                TotalDiscountPercent = currentInvoice.TotalDiscountPercent,
                TotalDiscountAmount = currentInvoice.TotalDiscountAmount,
                TotalInvoiceAmount = currentInvoice.TotalInvoiceAmount,
                CustomerId = customerId,
                Description = currentInvoice.Description,
                PrepaymentAmount = currentInvoice.PrepaymentAmount,
                InvoiceDetails = currentInvoiceDetailList
            };
            var result = await _invoiceApiClient.Create(invoiceCreateRequest);
            if (!result.IsSuccessed)
            {
                TempData["errorMsg"] = "Thiếu thông tin";
            }
            HttpContext.Session.Remove(SystemConstants.InvoiceSession);
            TempData["successMsg"] = "Thành công";
            return RedirectToAction("Details", "Customer", new { id = customerId });
        }
    }
}
