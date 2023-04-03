using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.Utilities.Constants;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices.InvoiceDetails;
using DentalManagement.ViewModels.Common;
using DentalManagement.Data.Enums;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

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
            var invoices = await _invoiceApiClient.GetAllPaging(request);
            return View(invoices.Data);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(int id)
        {
            var invoice = await _invoiceApiClient.GetbyId(id);
            return Ok(invoice.Data);
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
                    ProductName = product.Data.Name,
                    UnitPrice = product.Data.UnitPrice,
                    Quantity = quantity,
                    ItemAmount = product.Data.UnitPrice * quantity,
                };
                currentInvoiceDetailList.Add(item);
            }
            currentInvoice.InvoiceDetailViewModels = currentInvoiceDetailList;
            currentInvoice.TotalInvoiceAmount = currentInvoiceDetailList.Sum(x => x.ItemAmount) - currentInvoice.TotalDiscountAmount;
            currentInvoice.RemainAmount = currentInvoice.TotalInvoiceAmount - currentInvoice.PrepaymentAmount;
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
            var totalInvoiceAmount = currentInvoice.InvoiceDetailViewModels.Sum(x => x.ItemAmount);
            var prepaymentAmount = currentInvoice.PrepaymentAmount;
            var totalDiscountAmount = currentInvoice.TotalDiscountAmount;
            currentInvoice.TotalInvoiceAmount = totalInvoiceAmount - totalDiscountAmount;
            currentInvoice.RemainAmount = totalInvoiceAmount - totalDiscountAmount - prepaymentAmount;
            HttpContext.Session.SetString(SystemConstants.InvoiceSession, JsonConvert.SerializeObject(currentInvoice));
            return Ok(currentInvoice);
        }

        [HttpPost]
        public IActionResult UpdateTotalInvoiceAmount(decimal totalDiscountAmount, decimal prepaymentAmount)
        {
            var invoiceSession = HttpContext.Session.GetString(SystemConstants.InvoiceSession);
            var currentInvoice = new InvoiceViewModel();
            if (invoiceSession != null)
            {
                currentInvoice = JsonConvert.DeserializeObject<InvoiceViewModel>(invoiceSession);
            }
            var totalInvoiceAmount = currentInvoice.InvoiceDetailViewModels.Sum(x => x.ItemAmount);
            currentInvoice.TotalDiscountAmount = totalDiscountAmount;
            currentInvoice.PrepaymentAmount = prepaymentAmount;
            currentInvoice.TotalInvoiceAmount = totalInvoiceAmount - totalDiscountAmount;
            currentInvoice.RemainAmount = totalInvoiceAmount - totalDiscountAmount - prepaymentAmount;
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
                    CompletedDate = null,
                    Status = Status.Processing
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
                RemainAmount = currentInvoice.RemainAmount,
                InvoiceDetails = currentInvoiceDetailList
            };
            var result = await _invoiceApiClient.Create(invoiceCreateRequest);
            if (!result.IsSuccessed)
            {
                TempData["errorMsg"] = SystemConstants.AppErrorMessage.Create;
            }
            HttpContext.Session.Remove(SystemConstants.InvoiceSession);
            TempData["successMsg"] = "Ok";
            return RedirectToAction("Details", "Customer", new { id = customerId });
        }

        [HttpPost]
        public async Task<IActionResult> UpdateInvoiceDetailStatus(int invoiceId, int productId, Status updatedInvoiceDetailStatus, decimal prepaymentAmount)
        {
            var result = await _invoiceApiClient.UpdateInvoiceDetailStatus(invoiceId, productId, updatedInvoiceDetailStatus, prepaymentAmount);
            return Ok(result.Message);
        }
    }
}
