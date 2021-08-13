using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Hierarchy
{
    class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion):
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("pii pii pii");
        }

        public override void Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                Console.WriteLine($"{AnimalType} are not eating that type of food!");
            }
            Console.WriteLine($"{AnimalType}, [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]");
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            return result;
        }
    }
}
