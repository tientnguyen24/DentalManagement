﻿using DentalManagement.Application.Catalog.Invoices;
using DentalManagement.ViewModels.Catalog.Invoices;
using DentalManagement.Data.Enums;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<IActionResult> Get()
        {
            var invoices = await _invoiceService.GetAll();
            return Ok(invoices);
        }

        //http://localhost:port/invoice/customerId
        [HttpGet("customerId")]
        public async Task<IActionResult> Get([FromQuery] int customerId)
        {
            var invoices = await _invoiceService.GetAllByCustomerId(customerId);
            return Ok(invoices);
        }

        //http://localhost:port/invoice/search
        [HttpGet("search")]
        public async Task<IActionResult> Get([FromQuery] GetInvoicePagingRequest request)
        {
            var invoices = await _invoiceService.GetAllPaging(request);
            return Ok(invoices);
        }

        //http://localhost:port/invoice/{id}
        [HttpGet("{invoiceId}")]
        public async Task<IActionResult> GetById(int invoiceId)
        {
            var invoice = await _invoiceService.GetById(invoiceId);
            if (invoice == null)
            {
                return BadRequest();
            }
            return Ok(invoice);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] InvoiceCreateRequest request)
        {
            var data = await _invoiceService.Create(request);
            if (!data.IsSuccessed)
            {
                return BadRequest();
            }
            var invoice = await _invoiceService.GetById(data.ResultObject);
            return CreatedAtAction(nameof(GetById), new { id = data.ResultObject }, invoice);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] InvoiceUpdateRequest request)
        {
            var affectedResult = await _invoiceService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        //http://localhost:port/invoice/{id}/{updatedPaymentStatus}
        [HttpPatch("{invoiceId}/{updatedPaymentStatus}")]
        public async Task<IActionResult> UpdateStatus(int invoiceId, PaymentStatus updatedPaymentStatus)
        {
            var affectedResult = await _invoiceService.UpdateStatus(invoiceId, updatedPaymentStatus);
            if (!affectedResult)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int invoiceId)
        {
            var affectedResult = await _invoiceService.Delete(invoiceId);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
