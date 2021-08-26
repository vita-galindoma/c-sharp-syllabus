using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Cat : Felime
    {
        private string _breed;

        public Cat(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion, string breed) :
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            _breed = breed;
        }
        public override string MakeSound()
        {
            return "meouuw";
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            result += $", {_breed}";
            return result;
        }
        public override string Eat(Food food)
        { 
            FoodEaten += food.Quantity;
            return $"{AnimalType}, [{AnimalName}, {_breed}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

    }
}
