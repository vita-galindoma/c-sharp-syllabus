using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed) :
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }
        public override void MakeSound()
        {
            Console.WriteLine("meouuw");
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            result += $", {_breed}";
            return result;
        }
        public override void Eat(Food food)
        { 
            FoodEaten += food.Quantity;
            Console.WriteLine($"{AnimalType}, [{AnimalName}, {_breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]");
        }

    }
}
