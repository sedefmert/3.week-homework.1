namespace Interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal: ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted");
        }
    }
    
    class OracleServerCustomerDal: ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }

        public void Delete()
        {
            Console.WriteLine("oracle deleted");
        }
    }
    
    class MySqlServerCustomerDal: ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added");
        }

        public void Update()
        {
            Console.WriteLine("Mysql updated");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql deleted");
        }
    }


    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}

//polymorephism = çok biçimlilik. Bir nesneyi farklı amaçlarla implemente edip bu implementasyonlara ulaşmaktır.