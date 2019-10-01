using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
    class AsynchronousStreams
    {
        static string[] names = new string[] { "John", "Jack", "Ana", "Steven", "Jane", "Peter", "Chris" };

        //static async Task Main(string[] args)
        //{
        //    IAsyncEnumerable<Customer> customers = ClientAPI.GetCustomersAsyncStream(names);

        //    // Consuming an asynchronous stream requires you to add the 
        //    // await keyword before the foreach keyword
        //    await foreach (var customer in customers)
        //    {
        //        Console.WriteLine(customer);
        //    }
        //}

        static async Task Main(string[] args)
        {
            IEnumerable<Customer> customers = await ClientAPI.GetCustomersAsync(names);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }

        //static async Task Main(string[] args)
        //{
        //    foreach (var name in names)
        //    {
        //        var customer = await ClientAPI.GetCustomerAsync(name);
        //        Console.WriteLine(customer);
        //    }
        //}
    }
}
