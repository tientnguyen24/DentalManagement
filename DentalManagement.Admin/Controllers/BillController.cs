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
        public BillController(IProductApiClient productApiClient)
        {
            _productApiClient = productApiClient;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetListItems()
        {
            var session = HttpContext.Session.GetString(SystemConstants.BillSession);
            List<BillViewModel> currentBill = new List<BillViewModel>();
            if (session != null)
                currentBill = JsonConvert.DeserializeObject<List<BillViewModel>>(session);
            return Ok(currentBill);
        }

        public async Task<IActionResult> AddToBill(int id)
        {
            var product = await _productApiClient.GetById(id);
            var session = HttpContext.Session.GetString(SystemConstants.BillSession);
            List<BillViewModel> currentBill = new List<BillViewModel>();
            if (session != null)
                currentBill = JsonConvert.DeserializeObject<List<BillViewModel>>(session);
            int quantity = 1;
            if (currentBill.Any(x => x.ProductId == id))
            {
                quantity = currentBill.First(x => x.ProductId == id).Quantity + 1;
            }
            var billItem = new BillViewModel()
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
            List<BillViewModel> currentBill = new List<BillViewModel>();
            if (session != null)
                currentBill = JsonConvert.DeserializeObject<List<BillViewModel>>(session);
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
