using Microsoft.EntityFrameworkCore;
using dotnet_backend.Models;

namespace dotnet_backend.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        public DbSet<Product> Products { get; set; }
    }
}