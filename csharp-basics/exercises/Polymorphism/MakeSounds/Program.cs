using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var boom = new Firework();
            var bird = new Parrot();
            var fm = new Radio();

            List<ISound> sounds = new List<ISound>();
            sounds.Add(boom);
            sounds.Add(bird);
            sounds.Add(fm);

            foreach (var element in sounds)
            {
                element.PlaySound();
            }

            Console.ReadKey();
        }
    }
}