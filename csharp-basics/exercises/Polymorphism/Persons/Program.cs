using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Employee("Sofia", "Lorenzo", "King Street 2", 48541258, "pharmacist");
            var person2 = new Student("Edith", "Jacobson", "Apple Street 10", 45684292, 9.14); ;
            var person3 = new Person("Jan", "Van Deal", "Planet Street 45", 598436222); ;

            person1.Display();
            person2.Display();
            person3.Display();

            Console.ReadKey();
        }
    }
}