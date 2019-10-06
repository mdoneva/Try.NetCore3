using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
    class AsynchronousStreams
    {
        static string[] names = new string[] { "Milk", "Eggs", "Bread", "Water", "Apples", "Tomatoes", "Butter" };

        static async Task Main(string[] args)
        {
            IEnumerable<Product> products = await ProductAPI.GetProductsAsync(names);

            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        //static async Task Main(string[] args)
        //{
        //    IAsyncEnumerable<Product> products = ProductAPI.GetProductsAsyncStream(names);

        //    // Consuming an asynchronous stream requires you to add the 
        //    // await keyword before the foreach keyword
        //    await foreach (var product in products)
        //    {
        //        Console.WriteLine(product);
        //    }
        //}


        #region OneProduct
        //static async Task Main(string[] args)
        //{
        //    foreach (var name in names)
        //    {
        //        var product = await ProductAPI.GetProductAsync(name);
        //        Console.WriteLine(product);
        //    }
        //}
        #endregion
    }
}
