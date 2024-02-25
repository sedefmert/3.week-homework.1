// See https://aka.ms/new-console-template for more information

//katmanlar arası geçişlerde interface kullanılır.
namespace Interfaces
{
    class Program
    {
        public static void Main(string[] args)
        {
            //IntrafecesIntro();
            //Demo();

            
            
            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new OracleServerCustomerDal(),
                new SqlServerCustomerDal(),
                new MySqlServerCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add(); //elimizdeki veriyi tüm veri tabanlarına ekleme işlemi
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleServerCustomerDal());
        }

        private static void IntrafecesIntro() //refactor
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Sedef",
                LastName = "Mert",
                Address = "Edirne"
            };
            manager.Add(customer);
            
            Student student = new Student
            {
                Id = 1,
                FirstName = "Selin",
                LastName = "Çetiner",
                Departmant = "Computer Engineering"
            };
            manager.Add(student);
        }
    }

    interface IPerson
    {
        // temel nesne oluşturur.
        // soyut bir class
        
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }


    class PersonManager
    {
        public void Add(IPerson person)
        {
            // parametre olarak müşteri nesnesi alır

            Console.WriteLine(person.FirstName);
        }
    }
}
