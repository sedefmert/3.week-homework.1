// See https://aka.ms/new-console-template for more information

namespace  Loops
{
    class Program
    {
        public static void Main(string[] args)
        {
            // ForLoop();   
            //WhileLoop();
            //DoWhileLoop();
            //ForeachLoop();

            if (IsPrimeNumber(2))
            {
                Console.WriteLine("This is a prime number");
            }
            else
            {
                Console.WriteLine("This isn't a prime number");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            // verilen sayının asal olup olmadığını bulan method;

            bool result = true;

            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number; // tekrar döngüye girip uzamaması için i = number yapıp döngünden çıkarız.
                }
            }
            return result;
        }
        
        private static void ForeachLoop() // refactor
        {
            string[] students = new string[3] {"beyza","cem","İkbal"};
            foreach (var student  in students)
            {
                Console.WriteLine(student);
            }
            
            // foreach loopu genellikle databaseden çektiğimiz tabloların üzerinde gezmek için kullanılır.
        }

        private static void DoWhileLoop() //refactor
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            } while (number>=0);
        }

        private static void WhileLoop() //refactor
        {
            int number = 100;
            while (number>=0)
            {
                number--;
                Console.WriteLine(number);
            }

            Console.WriteLine("now number is:{0}", number);
        }

        private static void ForLoop() //refactor 
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("finished");
        }
    }

}
