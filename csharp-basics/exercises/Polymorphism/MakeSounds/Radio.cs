﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    class Radio : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("uuh la la la");
        }
    }
}
