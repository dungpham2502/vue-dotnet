using dotnet_backend.Models;

namespace dotnet_backend.Services
{
    public class ProductService
    {
        private static List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Apple" },
            new Product { Id = 2, Name = "Orange" },
        };
        public List<Product> GetProducts() => Products;
        public void Add(Product product) => Products.Add(product);
    }
}