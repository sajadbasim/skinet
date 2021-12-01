using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.Extensions.Logging;

namespace Infrastructuer.Data
{
    // fell database table from json files in the seed folder 
    public class StorContextSeed
    {
        public static async Task SeedAsync(StorContext context ,ILoggerFactory loggerFactory)
        {
            try
            {
                //product brand content
                if (!context.ProductBrand.Any())
                {
                    var brandsData = 
                        File.ReadAllText("../Infrastructuer/Data/SeedData/brands.json");

                    var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);

                    foreach(var item in brands)
                    {
                        context.ProductBrand.Add(item);                    
                    }
                    await context.SaveChangesAsync();
                }
                //product type content
                if (!context.ProductType.Any())
                {
                    var typesData = 
                        File.ReadAllText("../Infrastructuer/Data/SeedData/types.json");

                    var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);

                    foreach(var item in types)
                    {
                        context.ProductType.Add(item);                    
                    }
                    await context.SaveChangesAsync();
                }
                //product content
                 if (!context.prodect.Any())
                {
                    var productsData = 
                        File.ReadAllText("../Infrastructuer/Data/SeedData/products.json");

                    var products = JsonSerializer.Deserialize<List<prodect>>(productsData);

                    foreach(var item in products)
                    {
                        context.prodect.Add(item);                    
                    }
                    await context.SaveChangesAsync();
                }

            }
            // Return an Error Message 
            catch(Exception ex)
            {
                var logger = loggerFactory.CreateLogger<StorContextSeed>();
                logger.LogError(ex.InnerException.Message);
            }
        }
    }
}