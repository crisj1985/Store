using Core.Interfaces;
using Core.Entities;
using System.Threading.Tasks;

namespace Infrastruture.Data
{
    public class ProductRepository : IProductRepository
    {
        public Task<Product> GetProductByIdAsync(int id)
        {

        }
        public Task<IReadOnlyList<Product>> GetProductsAsync()
        {

        }
    }
}