using Microsoft.AspNetCore.Mvc;
using dotnet_backend.Models;
using dotnet_backend.Services;
using dotnet_backend.DTOs;

namespace dotnet_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetProducts();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductDto productDto)
        {
            var product = await _productService.AddProduct(productDto.Name);
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}
