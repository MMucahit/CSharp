using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara", "Samsun", "İstanbul");
            List<Customer> result1 = utilities.BuildList<Customer>(new Customer { Name = "Mücahit", LastName = "NAS" }, new Customer { Name = "Muhammed", LastName = "NAS" });
            List<Product> result2 = utilities.BuildList<Product>(new Product { Dephartman = "Mühendis", Class = "Mekatronik" }, new Product { Dephartman = "Yönetici", Class = "Müdür" });

            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            foreach (var customer in result1)
            {
                Console.WriteLine(customer.Name);
            }

            foreach (var product in result2)
            {
                Console.WriteLine(product.Dephartman);
            }

            Console.ReadLine();

        }

        class Utilities
        {
            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }

        }

        interface IRepository<T> where T : class,IEntity, new()//class = referans tip olmalı ve IEntity'den iplemente edilmeli ve new'lene bilir olmalı new en sonda olcak hep
        {                                                      // sadece değer tip icin struct yazılacak
            List<T> GetAll();
            T Get(int id);
            void Add();
            void Delete();
        }

        interface IEntity
        {
            
        }

        interface IProductDal:IRepository<Product>
        {
            void Producter();
        }

        interface ICustomerDal:IRepository<Customer>
        {
            void Custom();
        }



        class Customer:ICustomerDal, IEntity
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public void Add()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public void Custom()
            {
                throw new NotImplementedException();
            }
        }

        class Product:IProductDal, IEntity
        {
            public string Dephartman { get; set; }
            public string Class { get; set; }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public void Add()
            {
                throw new NotImplementedException();
            }

            public void Delete()
            {
                throw new NotImplementedException();
            }

            public void Producter()
            {
                throw new NotImplementedException();
            }
        }

    }
}
