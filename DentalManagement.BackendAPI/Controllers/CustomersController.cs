using DentalManagement.Application.Catalog.Customers;
using DentalManagement.ViewModels.Catalog.Customers;
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
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        //http://localhost:port/api/customer
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var customers = await _customerService.GetAll();
            return Ok(customers);
        }

        //http://localhost:port/api/customer/search
        [HttpGet("search")]
        public async Task<IActionResult> Get([FromQuery] GetCustomerPagingRequest request)
        {
            var customers = await _customerService.GetAllPaging(request);
            return Ok(customers);
        }

        //http://localhost:port/api/customer/{id}
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _customerService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CustomerCreateRequest request)
        {
            var customerId = await _customerService.Create(request);
            if (customerId == 0)
            {
                return BadRequest();
            }
            var customer = await _customerService.GetById(customerId);
            return CreatedAtAction(nameof(GetById), new { id = customerId }, customer);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]CustomerUpdateRequest request)
        {
            var result = await _customerService.Update(request);
            if (!result.IsSuccessed)
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        //http://localhost:port/api/customer/{id}/{status}
        [HttpPatch("{id}/{updatedStatus}")]
        public async Task<IActionResult> UpdateStatus(int id, Status updatedStatus)
        {
            var result = await _customerService.UpdateStatus(id, updatedStatus);
            if (!result)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromForm]CustomerDeleteRequest request)
        {
            var result = await _customerService.Delete(request);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

    }
}
