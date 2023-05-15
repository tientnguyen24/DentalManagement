using DentalManagement.Application.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.Data.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using DentalManagement.Data.Entities;

namespace DentalManagement.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class InvoicesController : ControllerBase
    {
        private readonly IInvoiceService _invoiceService;
        public InvoicesController(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        //http://localhost:port/invoice
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _invoiceService.GetAll();
            return Ok(data);
        }

        //http://localhost:port/invoice/search
        [HttpGet("search")]
        public async Task<IActionResult> GetAllPaging([FromQuery] GetInvoicePagingRequest request)
        {
            var data = await _invoiceService.GetAllPaging(request);
            return Ok(data);
        }

        //http://localhost:port/invoice/{invoiceId}
        [HttpGet("{invoiceId}")]
        public async Task<IActionResult> GetById(int invoiceId)
        {
            var data = await _invoiceService.GetById(invoiceId);
            if (data == null)
            {
                return BadRequest();
            }
            return Ok(data);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] InvoiceCreateRequest request)
        {
            var result = await _invoiceService.Create(request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result.Message);
            }
            var invoice = await _invoiceService.GetById(result.Data);
            return CreatedAtAction(nameof(GetById), new { id = result.Data }, invoice);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] InvoiceUpdateRequest request)
        {
            var result = await _invoiceService.Update(request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        //http://localhost:port/invoice/{invoiceId}/{updatedPaymentStatus}
        [HttpPatch("{invoiceId}/{updatedPaymentStatus}")]
        public async Task<IActionResult> UpdatePaymentStatus(int invoiceId, PaymentStatus updatedPaymentStatus)
        {
            var result = await _invoiceService.UpdatePaymentStatus(invoiceId, updatedPaymentStatus);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

        //http://localhost:port/invoice/{invoiceId}/{productId}/{updatedInvoiceDetailStatus}/{prepaymentAmount}
        [HttpPatch("{invoiceId}/{productId}/{updatedInvoiceDetailStatus}/{prepaymentAmount}")]
        public async Task<IActionResult> UpdateInvoiceDetailStatus(int invoiceId, int productId, Status updatedInvoiceDetailStatus, decimal prepaymentAmount)
        {
            var result = await _invoiceService.UpdateInvoiceDetailStatus(invoiceId, productId, updatedInvoiceDetailStatus, prepaymentAmount);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int invoiceId)
        {
            var result = await _invoiceService.Delete(invoiceId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        //http://localhost:port/invoice/{invoiceId}/{productId}
        [HttpGet("{invoiceId}/{productId}")]
        public async Task<IActionResult> GetInvoiceDetailById(int invoiceId, int productId)
        {
            var result = await _invoiceService.GetInvoiceDetailById(invoiceId, productId);
            if (result == null)
            {
                return BadRequest();
            }
            return Ok(result);
        }
    }
}
