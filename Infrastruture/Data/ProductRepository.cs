using Core.Interfaces;
using Core.Entities;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Data
{


    public class ProductRepository : IProductRepository
    {
        private readonly StoreDbContext _config;

        public ProductRepository(StoreDbContext config)
        {
            _config = config;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            return await _config.Products.FindAsync(id);
        }
        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _config.Products.ToListAsync();
        }
    }
}