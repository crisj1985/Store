using Microsoft.EntityFrameworkCore;
using Core.Entities;
namespace Infrastruture.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext (DbContextOptions options) : base (options)
        {

        }    
        public DbSet<Product> Products { get; set; }
    }
}