using DentalManagement.Admin.Models;
using DentalManagement.ApiIntegration.ApiIntegrations;
using DentalManagement.Utilities.Constants;
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
        public BillController(IProductApiClient productApiClient, ICustomerApiClient customerApiClient)
        {
            _productApiClient = productApiClient;
            _customerApiClient = customerApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillSession);
            List<BillItemViewModel> currentBill = new List<BillItemViewModel>();
            if (session != null)
                currentBill = JsonConvert.DeserializeObject<List<BillItemViewModel>>(session);
            return Ok(currentBill);
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
            HttpContext.Session.SetString(SystemConstants.ProductSession, JsonConvert.SerializeObject(currentProduct));
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
                    IdentifyCard = item.IdentifyCard
                };
                currentCustomer.Add(customerItem);
            }
            HttpContext.Session.SetString(SystemConstants.CustomerSession, JsonConvert.SerializeObject(currentCustomer));
            return Ok(currentCustomer);
        }
        public async Task<IActionResult> AddProductToBill(int id)
        {
            var product = await _productApiClient.GetById(id);
            var session = HttpContext.Session.GetString(SystemConstants.BillSession);
            List<BillItemViewModel> currentBill = new List<BillItemViewModel>();
            if (session != null)
                currentBill = JsonConvert.DeserializeObject<List<BillItemViewModel>>(session);
            int quantity = 1;
            if (currentBill.Any(x => x.ProductId == id))
            {
                quantity = currentBill.First(x => x.ProductId == id).Quantity + 1;
            }
            var billItem = new BillItemViewModel()
            {
                ProductId = id,
                ProductName = product.ResultObject.Name,
                UnitPrice = product.ResultObject.UnitPrice,
                Quantity = quantity
            };
            currentBill.Add(billItem);
            HttpContext.Session.SetString(SystemConstants.BillSession, JsonConvert.SerializeObject(currentBill));
            return Ok(currentBill);
        }

        public IActionResult UpdateBill(int id, int quantity)
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillSession);
            List<BillItemViewModel> currentBill = new List<BillItemViewModel>();
            if (session != null)
                currentBill = JsonConvert.DeserializeObject<List<BillItemViewModel>>(session);
            foreach(var item in currentBill)
            {
                if(item.ProductId == id) {
                    if (quantity == 0)
                    {
                        currentBill.Remove(item);
                        break;
                    }
                    item.Quantity = quantity;
                }
            }
            HttpContext.Session.SetString(SystemConstants.BillSession, JsonConvert.SerializeObject(currentBill));
            return Ok(currentBill);
        }
    }
}
