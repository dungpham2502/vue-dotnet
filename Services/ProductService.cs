using dotnet_backend.Models;
using dotnet_backend.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_backend.Services
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> AddProduct(String name)
        {
            var product = new Product { Name = name };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }
    }
}