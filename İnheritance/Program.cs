using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Mücahit",
                    LastName = "NAS",
                    Id = 1,
                    city = "Samsun"
                }, 
                new Student
                {
                    FirstName = "Osman",
                    LastName = "Türkmen",
                    Id = 2,
                    Departmant = "Besyo"

                },
                new Person
                {
                    FirstName = "Suat",
                    LastName = "Sarıbuğa",
                    Id = 3
                }
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string city { get; set; }
    }

    class Student :Person
    {
        public string Departmant { get; set; }
    }
}
