using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Tiger : Felime
    {
        
        public Tiger(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion) :
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            
        }
        public override string MakeSound()
        {
            return "rrrrr";
        }

        public override string Eat(Food food)
        {
            if (food is Meat)
            {
                FoodEaten = FoodEaten + food.Quantity;
                return $"{AnimalType}, [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
            }
            return $"{AnimalType} are not eating that type of food!";

        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            return result;
        }
    }
}