using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayL();

            //List();

            Dictionary<string,string> dictionary = new Dictionary<string, string>();

            dictionary.Add("book","kitap");
            dictionary.Add("car","araba");
            dictionary.Add("apple","elma");

            foreach (var Dic in dictionary)
            {
                Console.WriteLine(Dic.Value);
                Console.WriteLine(Dic.Key);
                Console.WriteLine(Dic);
            }

            Console.WriteLine(dictionary["apple"]);

            Console.ReadLine();
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Adana");

            foreach (var city in cities)
            {
                //Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer{id = 2 ,FirstName = "Mücahit"});
            //customers.Add(new Customer{FirstName = "Samet",id = 2});

            List<Customer> customers = new List<Customer>
            {
                new Customer {id = 1, FirstName = "Mücahit"},
                new Customer {FirstName = "Samet", id = 2}
            };


            var customerr = new Customer
            {
                id = 3, FirstName = "Osman"
            };

            customers.Add(customerr);

            var Find = new Customer
            {
                id = 1,
                FirstName = "Mücahit"
            };
            customers.Add(Find);

            customers.AddRange(new Customer[2]
            {
                new Customer {id = 4, FirstName = "Suat"},
                new Customer {id = 5, FirstName = "Müslüm"}
            });

            //customers.Clear();

            customers.Add(Find);

            customers.Insert(0, Find);

            customers.Remove(Find); //ilk gordugunu siler işlemi bitirir.

            int count = customers.Count;
            Console.WriteLine("\nListede {0} tane eleman var.", count);

            foreach (var customer in customers)
            {
                Console.WriteLine("FirstName: {0} İd: {1}", customer.FirstName, customer.id);
            }


            int index = customers.IndexOf(Find);
            int LastIndex = customers.LastIndexOf(Find);
            Console.WriteLine("LastIndex: {0}", LastIndex);
            Console.WriteLine("Index: {0}", index);

            Console.WriteLine(customers.Contains(Find));
            //Console.WriteLine(customers.Contains(new Customer{id = 1 ,FirstName = "Mücahit"}));new dedıgımız ıcın yenı olusturduk false dondu
        }


        private static void ArrayL()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Samsun");
            cities.Add("Tokat");
            cities.Add("Sinop");
            cities.Add(1);
            cities.Add('A');

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }

    class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
    }
}
