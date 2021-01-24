using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
    }

    class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }

        public virtual void Deleted()
        {
            Console.WriteLine("Deleted by default");
        }
    }

    class SqlServer:DataBase
    {
        public override void Add()
        {
            //base.Add();
            Console.WriteLine("Added by Sql Code");
        }
    }

    class MySql:DataBase
    {
        
    }
}
