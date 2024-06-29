using EcomApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EcomApp.Data;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions<ProductContext> options):base(options)
    {
    }
    public DbSet<Review> Reviews { get; set; } = null!;
}