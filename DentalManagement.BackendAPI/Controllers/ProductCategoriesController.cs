using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using DentalManagement.Application.Catalog.ProductCategories;
using DentalManagement.ViewModels.Catalog.ProductCategories;

namespace DentalManagement.BackendAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ProductCategoriesController : ControllerBase
    {
        private readonly IProductCategoryService _productCategoryService;
        public ProductCategoriesController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductCategoryCreateRequest request)
        {
            var result = await _productCategoryService.Create(request);
            if (!result.IsSuccessed) return BadRequest();
            return CreatedAtAction("", result.Data);
        }
    }
}
