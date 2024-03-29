﻿using DentalManagement.Application.Catalog.Products;
using DentalManagement.ViewModels.Catalog.Products;
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
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //http://localhost:port/product
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }

        //http://localhost:port/product/search
        [HttpGet("search")]
        public async Task<IActionResult> Get([FromQuery]GetProductPagingRequest request)
        {
            var products = await _productService.GetAllPaging(request);
            return Ok(products);
        }

        //http://localhost:port/product/filter
        [HttpGet("filter")]
        public async Task<IActionResult> Get([FromQuery]GetProductByCategoryIdRequest request)
        {
            var products = await _productService.GetAllByProductCategoryId(request);
            return Ok(products);
        }
        
        //http://localhost:port/product/{id}
        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId)
        {
            var product = await _productService.GetById(productId);
            if (product == null)
            {
                return BadRequest();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCreateRequest request)
        {
            var productId = await _productService.Create(request);
            if (productId == 0)
            {
                return BadRequest();
            }
            var product = await _productService.GetById(productId);
            return CreatedAtAction(nameof(GetById), new { id = productId }, product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ProductUpdateRequest request)
        {
            var affectedResult = await _productService.Update(request);
            if (affectedResult == 0)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpPatch("{productId}/{updatedStatus}")]
        public async Task<IActionResult> UpdateStatus(int productId, Status updatedStatus)
        {
            var affectedResult = await _productService.UpdateStatus(productId, updatedStatus);
            if (!affectedResult)
            {
                return BadRequest();
            }
            return Ok();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] int productId)
        {
            var result = await _productService.Delete(productId);
            if (result == 0)
            {
                return BadRequest();
            }
            return Ok();
        }
    }
}
