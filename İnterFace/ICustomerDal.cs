using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterFace
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");
        }
    }

    class OracleCustomerDal:ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

        public void Delete(ICustomerDal customerDal)
        {
            customerDal.Delete();
        }

        public void Update(ICustomerDal customerDal)
        {
            customerDal.Update();
        }
    }
}
