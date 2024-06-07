

using System.Text.Json;
using Core.Entities;
using Infastructure.Data;

namespace InfraStructure.Data
{
    public class StoreContextSeed
    {
        public static async Task SeedAsync(StoreContext context)
        {
            if(!context.ProductBrands.Any())
            {
                var brandsData  = File.ReadAllText("../Infastructure/Data/SeedData/brands.json");
                var brands = JsonSerializer.Deserialize<List<ProductBrand>>(brandsData);
                context.ProductBrands.AddRange(brands);
            }

             if(!context.ProductTypes.Any())
            {
                var typesData  = File.ReadAllText("../Infastructure/Data/SeedData/types.json");
                var types = JsonSerializer.Deserialize<List<ProductType>>(typesData);
                context.ProductTypes.AddRange(types);
            }

             if(!context.Products.Any())
            {
                var productsData  = File.ReadAllText("../Infastructure/Data/SeedData/shovels.json");
                var products = JsonSerializer.Deserialize<List<Product>>(productsData);
                context.Products.AddRange(products);
            }


            if(context.ChangeTracker.HasChanges()) await context.SaveChangesAsync();
        }
    }
}