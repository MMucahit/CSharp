using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.List();
            EmployeeManager employee = new EmployeeManager(new DatabaseLogger());
            employee.Add();

            PersonManager personManager = new PersonManager("Product");
            //personManager.Print();


            Console.ReadLine();
        }
    }

    class CustomerManager
    {
        private int _count = 15;
        public CustomerManager(int count)
        {
            _count = count;
        }

        public CustomerManager()
        {
            
        }

        public void List()
        {
            Console.WriteLine("{0} Customer Listed!",_count);
        }

        public void Add()
        {
            Console.WriteLine("Added!");
        }

        
    }

    interface ILogger
    {
    void log();
    }

    class DatabaseLogger:ILogger
    {

        public void log()
        {
            Console.WriteLine("Logged Database");
        }
    }

    class FileLogger:ILogger
    {

        public void log()
        {
            Console.WriteLine("Logged File");
        }
    }


    class EmployeeManager
    {
        private ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.log();
            Console.WriteLine("Added!");
        }
    }

    class BaseClass
    {
        private string _entity;

        public BaseClass(string entity)
        {
            _entity = entity;
        }
        public void Message()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity):base(entity)
        {
            
        }

        public void Print()
        {
            Message();
        }
    }

}
