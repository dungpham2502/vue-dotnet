using dotnet_backend.Models;

namespace dotnet_backend.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IProductService
{
    Task<List<Product>> GetProducts();
    Task<Product> AddProduct(string Name);
}