using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    abstract class Mammal : Animal
    {
        private string _livingRegion;
        public string LivingRegion
        {
            get => _livingRegion;
            set => _livingRegion = value;
        }

        protected Mammal(string animalName, string animalType, double animalWeight, int foodEaten, string livingRegion)
            : base(animalName, animalType, animalWeight, foodEaten)
        {
            _livingRegion = livingRegion;
        }

        public override string ReturnInfo()
        {
            var result = base.ReturnInfo();
            result += $", {_livingRegion}";
            return result;
        }
    }
}
