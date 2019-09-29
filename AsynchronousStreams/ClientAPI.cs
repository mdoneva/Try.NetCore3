using System.Collections.Generic;
using System.Threading.Tasks;

namespace AsynchronousStreams
{
    public class ClientAPI
    {
        public static async IAsyncEnumerable<Customer> GetCustomersAsyncStream(string[] names)
        {
            foreach (var name in names)
            {
                yield return await CustomerAPI.GetCustomerAsync(name);
            }
        }

        public static async Task<IEnumerable<Customer>> GetCustomersAsync(string[] names)
        {
            List<Customer> customers = new List<Customer>();

            foreach (var name in names)
            {
                customers.Add(await CustomerAPI.GetCustomerAsync(name));
            }

            return customers;
        }

        public static Task<Customer> GetCustomerAsync(string name)
        {
            return CustomerAPI.GetCustomerAsync(name);
        }
    }
}
