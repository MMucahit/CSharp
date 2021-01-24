using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classlar;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Mücahit";
            customer.LastName = "Nas";
            customer.City = "Samsun";
            Console.WriteLine(customer.FirstName);

            Customer customer2 = new Customer()
            {
                Id = 2, FirstName = "Muhammed", City = "Samsun"
            };
            Console.WriteLine(customer2.FirstName);



            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added!");
        }

        public void Update()
        {
            Console.WriteLine("Customer Updated!");
        }

    }

    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");
        }

        public void Update()
        {
            Console.WriteLine("Product Updated!");
        }

    }

}
