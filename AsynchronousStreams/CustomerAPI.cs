using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
    public class Customer
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public override string ToString() => $"Customer {Name} is {Age} years old.";
    }

    public static class CustomerAPI
    {
        public static async IAsyncEnumerable<Customer> GetCustomersAsyncStream(string[] names)
        {
            foreach (var name in names)
            {
                // Simulate waiting for data to come through the API
                await Task.Delay(1000);
                yield return new Customer { Age = GetAge(), Name = name };
            }
        }

        // Common intuitive approach, it's a trap
        public static async Task<IEnumerable<Customer>> GetCustomersAsync(string[] names)
        {
            List<Customer> customers = new List<Customer>();

            foreach (var name in names)
            {
                // Simulate waiting for data to come through. 
                await Task.Delay(1000);
                customers.Add(new Customer { Age = GetAge(), Name = name });
            }

            return customers;
        }

        private static int GetAge()
        {
            Random random = new Random();
            return random.Next(20, 40);
        }
    }
}
