﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Hierarchy
{
    public class Vegetable : Food
    {
        public Vegetable(string foodType, int quantity) : base(foodType, quantity)
        {
            foodType = "Vegetable";
        }

    }
}
