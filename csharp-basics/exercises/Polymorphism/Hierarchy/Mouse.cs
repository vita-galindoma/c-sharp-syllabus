﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Hierarchy
{
    public class Mouse : Mammal
    {
        public Mouse(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion):
            base(animalName, animalType, animalWeight, foodEaten, livingRegion)
        {
            
        }

        public override string MakeSound()
        {
            return "pii pii pii";
        }

        public override string Eat(Food food)
        {
            if (food is Vegetable)
            {
                FoodEaten += food.Quantity;
            }
            else
            {
                return $"{AnimalType} are not eating that type of food!";
            }
            return $"{AnimalType}, [{AnimalName}, {AnimalWeight}, {LivingRegion}, {FoodEaten}]";
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            return result;
        }
    }
}
