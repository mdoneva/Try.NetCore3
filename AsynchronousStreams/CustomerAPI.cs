using System;
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
        public static async Task<Customer> GetCustomerAsync(string name)
        {
            // Simulate waiting for data to come through the API
            await Task.Delay(1000);
            return new Customer { Age = GetAge(), Name = name };
        }

        private static int GetAge()
        {
            Random random = new Random();
            return random.Next(20, 40);
        }
    }
}
