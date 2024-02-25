// See https://aka.ms/new-console-template for more information

namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            //classı kullanabilmek için önce newlemek, yani bir örneğini oluşturmak gereklidirç.
             
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.City = "ankara";
            customer.Id = 1;
            customer.FirstName = "Sedef";
            customer.LastName = "Mert";

            Customer customer2 = new Customer()
            {
                Id =2, City = "İstanbul", FirstName = "Cem",LastName = "Karaca"
            };

            Console.WriteLine(customer2.FirstName + customer2.LastName);
        }
        
    }
 
    // bir class içerisinde o class ile ilgili methodları bulundurur.
}
