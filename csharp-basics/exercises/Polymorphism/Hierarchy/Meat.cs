﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Meat : Food
    {
        public Meat(string foodType, int quantity) : base(foodType, quantity)
        {
            foodType = "Meat";
        }
    }
}
