using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
    class AsynchronousStreams
    {
        //static async Task Main(string[] args)
        //{
        //    string[] names = new string[] { "John", "Jack", "Ana", "Steven", "Jane", "Peter", "Chris" };

        //    IAsyncEnumerable<Customer> customers = CustomerAPI.GetCustomersAsyncStream(names[0..]);

        //    // Consuming an asynchronous stream requires you to add the 
        //    // await keyword before the foreach keyword
        //    await foreach (var customer in customers)
        //    {
        //        Console.WriteLine(customer);
        //    }
        //}

        static async Task Main(string[] args)
        {
            string[] names = new string[] { "John", "Jack", "Ana", "Steven", "Jane", "Peter", "Chris" };

            IEnumerable<Customer> customers = await CustomerAPI.GetCustomersAsync(names);

            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
    }
}
