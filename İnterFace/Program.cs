using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace
{
    class Program
    {
        static void Main(string[] args)
        {
            //İnterfaceIntro();
            //AddDeleteUpdate();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }

        private static void AddDeleteUpdate()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
            customerManager.Delete(new SqlServerCustomerDal());
            customerManager.Update(new OracleCustomerDal());
        }

        private static void İnterfaceIntro()
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                Firsname = "Mücahit",
                Lastname = "NAS",
                Adress = "Cedit"
            };
            Student student = new Student
            {
                Id = 1,
                Firsname = "Samet",
                Lastname = "Akarcesme",
                Departman = "Mechatronic"
            };

            manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string Firsname { get; set; } 
            string Lastname { get; set; }
        }

        class Customer:IPerson
        {
            public int Id { get; set; }
            public string Firsname { get; set; }
            public string Lastname { get; set; }

            public string Adress { get; set; }
        }

        class Student:IPerson
        {
            public int Id { get; set; }
            public string Firsname { get; set; }
            public string Lastname { get; set; }

            public string Departman { get; set; }
        }

        class PersonManager
        {
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.Firsname);
            }
            public void Add(Student student)
            {
                Console.WriteLine(student.Departman);
            }
        }
    }
}
