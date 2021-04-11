using System.Collections.Generic;
using System.Linq;

namespace MySelfHostServiceConsoleApplication
{
    public class CustomerService : ICustomer
    {
        List<Customer> customers = new List<Customer>();

        public CustomerService()
        {
            customers = new List<Customer>() {
                new Customer
                {
                    CustomerId = 0,
                    Name = "Mateus",
                    Email = "moliveirabrito@gmail.com",
                    CreditCardNumber = "12345678"
                },
                new Customer
                {
                    CustomerId = 1,
                    Name = "Eduardo",
                    Email = "moliveirabrito@gmail.com",
                    CreditCardNumber = "12345678"
                },
                new Customer
                {
                    CustomerId = 2,
                    Name = "Diego",
                    Email = "moliveirabrito@gmail.com",
                    CreditCardNumber = "12345678"
                },
                new Customer
                {
                    CustomerId = 3,
                    Name = "Carlos",
                    Email = "moliveirabrito@gmail.com",
                    CreditCardNumber = "12345678"
                }
                };
        }

        public Customer CreateCustomer(int customerId, string name, string email)
        {
            var customer = new Customer();
            customer.CustomerId = customerId;
            customer.Name = name;
            customer.Email = email;

            return customer;
        }

        public Customer[] GetAllCustomers()
        {
            return customers.ToArray();
        }

        public Customer GetCustomerByName(string customerName)
        {
            return (from c in customers where c.Name == customerName select c).First();
        }
    }
}
