// See https://aka.ms/new-console-template for more information

//inheritance -kalıtım
//bir nesneyi bir kere inheritance alınabilir, ama birden fazla implementasyon yapılabilir.

//interfaceler inheritance mantığıyla da kullanılabilir.
//abstract classlar için inheritance önemlidir.

namespace Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName = "Sedefff"
                },
                new Student
                {
                    FirstName = "Hüseyin"
                },
                new Person
                {
                    FirstName = "İnci"
                }
                
            };

            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);   
            }
        }
    }

    class Person // base class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }

    class Person2
    {
        
    }

    class Customer : Person  //Person2 2 tane class miras bulunmaz.
    {
        public string City { get; set; } 
    }

    class Student: Person
    {
        public string Department { get; set; } 
    }

}
