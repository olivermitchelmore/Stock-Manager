using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopStock
{
    class CustomerList
    {
        public List<Customer> customers = new();

        public void AddCustomer(Customer customer)
        {
            customers.Add(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            customers.Remove(customers[customerId]);
        }

        public void PrintAllCustomers()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                Console.WriteLine($"{i}) {customers[i]}");
            }
        }

        public bool CheckPassword(int customerId, string customerpassword)
        {

            return customers[customerId].Password == customerpassword;

            
            
        }
    }
}
