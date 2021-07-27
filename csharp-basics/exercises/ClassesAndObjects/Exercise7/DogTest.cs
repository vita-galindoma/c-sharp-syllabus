using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog("Max", "male", "Lady", "Rocky");  
            Dog dog2 = new Dog("Rocky", "male", "Molly", "Sam");
            Dog dog3 = new Dog("Sparky", "male", null, null);
            Dog dog4 = new Dog("Buster", "male", "Lady", "Sparky");
            Dog dog5 = new Dog("Sam", "male", null, null);
            Dog dog6 = new Dog("Lady", "female", null, null);
            Dog dog7 = new Dog("Molly", "female", null, null);
            Dog dog8 = new Dog("Coco", "female", "Molly", "Buster");

            Console.WriteLine(dog8.FathersName());
            Console.WriteLine(dog3.FathersName());
            Console.WriteLine(dog8.HasSameMotherAs(dog2));
        }
    }
}
