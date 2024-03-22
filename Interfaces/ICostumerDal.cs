using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICostumerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCostumerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated!");
        }
    }
    class OracleServerCostumerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }
    class MySqlServerCostumerDal : ICostumerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql Added!");
        }

        public void Delete()
        {
            Console.WriteLine("MySql Deleted!");
        }

        public void Update()
        {
            Console.WriteLine("MySql Updated!");
        }
    }
    class CostumerManager
    {
        public void Add(ICostumerDal costumerDal)
        {
            costumerDal.Add();
        }
    }
}
