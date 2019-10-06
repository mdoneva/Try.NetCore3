using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
    public class Product
    {
        public decimal Price { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"Product '{Name}' costs ${Price}.";
    }

    public static class ProductAPI
    {
        private static async Task<Product> GetProductAsync(string name)
        {
            // Simulate waiting for data to come through the API
            await Task.Delay(1000);
            return new Product { Price = GetPrice(), Name = name };
        }

        public static async Task<IEnumerable<Product>> GetProductsAsync(string[] names)
        {
            List<Product> products = new List<Product>();

            foreach (var name in names)
            {
                products.Add(await GetProductAsync(name));
            }

            return products;
        }

        public static async IAsyncEnumerable<Product> GetProductsAsyncStream(string[] names)
        {
            foreach (var name in names)
            {
                yield return await GetProductAsync(name);
            }
        }

        public static Task<Product> GetSingleProductAsync(string name)
        {
            return GetProductAsync(name);
        }

        private static int GetPrice()
        {
            Random random = new Random();
            return random.Next(2, 10);
        }
    }
}
