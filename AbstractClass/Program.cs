using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new SqlServer();
            database.Add();
            database.Deleted();
            Database databasee = new Oracle();
            databasee.Add();
            databasee.Deleted();

            Console.ReadLine();
        }

        abstract class Database
        {
            public void Add()
            {
                Console.WriteLine("Added by default");
            }

            public abstract void Deleted();
        }

        class SqlServer:Database
        {
            public override void Deleted()
            {
                Console.WriteLine("Deleted by Sql");
            }
        }

        class Oracle:Database
        {
            public override void Deleted()
            {
                Console.WriteLine("Deleted by Oracle");
            }
        }
    }

}
