using Microsoft.AspNetCore.Mvc;
using dotnet_backend.Models;
using dotnet_backend.Services;

namespace dotnet_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] Product product)
        {
            _productService.Add(product);
            return Ok(_productService.GetProducts());
        }
    }
}
