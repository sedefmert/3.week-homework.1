namespace Classes;

public class CustomerManager
{
        //müşteri ile ilgili işlemleri koyarız.
        public void Add()
        {
            //single responsilbilty , bir method bir iş.
            Console.WriteLine("Customer Added");
        }
        public void Update()
        {
            Console.WriteLine("Customer Updated");
        }

}