using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastruture.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreDbContext context, ILoggerFactory loggerFactory)
        {
            try
            {
                if(!context.ProductBrands.Any())
                {

                    var brands = File.ReadAllText("../Infrastruture/Data/SeedData/brands.json");
                    var brandsJson = JsonSerializer.Deserialize<List<ProductBrand>>(brands);

                    foreach(var item in brandsJson)
                    {
                        context.ProductBrands.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.ProductTypes.Any())
                {
                    var types = File.ReadAllText("../Infrastruture/Data/SeedData/types.json");
                    var typesJson = JsonSerializer.Deserialize<List<ProductType>>(types);

                    foreach (var item in typesJson)
                    {
                        context.ProductTypes.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

                if (!context.Products.Any())
                {
                    var products = File.ReadAllText("../Infrastruture/Data/SeedData/products.json");
                    var productsJson = JsonSerializer.Deserialize<List<Product>>(products);

                    foreach (var item in productsJson)
                    {
                        context.Products.Add(item);
                    }
                    await context.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                logger.LogError(ex.Message);
            }
        }
    }
}