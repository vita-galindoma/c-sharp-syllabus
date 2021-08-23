using System;
using System.Collections.Generic;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();
            string userInput3 = "";

            do
            {
                Console.WriteLine("Enter info about the animal:");
                Console.WriteLine(
                    "{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if it is a cat]");
                var userInput = Console.ReadLine().Split(" ");

                var animalType = userInput[0];
                var animalName = userInput[1];
                var animalWeight = Convert.ToDouble(userInput[2]);
                var animalLivingRegion = userInput[3];
                
                switch (animalType)
                {
                    case "Mouse":
                        var mouse = new Mouse(animalName, animalType, animalWeight, 0, animalLivingRegion);
                        animals.Add(mouse);
                        mouse.MakeSound();
                        break;

                    case "Cat":
                        var catBreed = userInput[4];
                        var cat = new Cat(animalName, animalType, animalWeight, 0, animalLivingRegion, catBreed);
                        animals.Add(cat);
                        cat.MakeSound();
                        break;

                    case "Zebra":
                        var zebra = new Zebra(animalName, animalType, animalWeight, 0, animalLivingRegion);
                        animals.Add(zebra);
                        zebra.MakeSound();
                        break;

                    case "Tiger":
                        var tiger = new Tiger(animalName, animalType, animalWeight, 0, animalLivingRegion);
                        animals.Add(tiger);
                        tiger.MakeSound();
                        break;
                }

                Console.WriteLine("Enter info about the food:");
                Console.WriteLine("{FoodType} {quantity}");
                var userInput2 = Console.ReadLine()?.Split(" ");
                var foodType = userInput2[0];
                var quantity = Convert.ToInt32(userInput2[1]);
                if (foodType == "Meat")
                {
                    var meat = new Meat(foodType, quantity);
                    animals[^1].Eat(meat);
                }

                if (foodType == "Vegetable") 
                {
                    var vegetable = new Vegetable(foodType, quantity);
                    animals[^1].Eat(vegetable);
                }
                
                Console.WriteLine("Continue? yes/no");
                userInput3 = Console.ReadLine();
            } while (userInput3 != "no");

            foreach (var animal in animals)
            {
                Console.WriteLine(animal.ReturnInfo());
            }

            Console.ReadLine();
        }
    }
}