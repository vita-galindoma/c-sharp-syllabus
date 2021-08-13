using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    class Meat : Food
    {
        public Meat(string foodType, int quantity) : base(foodType, quantity)
        {
            foodType = "Meat";
        }
    }
}
