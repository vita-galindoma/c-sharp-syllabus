using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        public Zebra(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion):
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            
        }
        public override string MakeSound()
        {
            return "hhheeellloo";
        }

        public override string Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                return ($"{AnimalType} are not eating that type of food!");
            }
            return ($"{AnimalType}, [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]");
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            return result;
        }
    }
}
