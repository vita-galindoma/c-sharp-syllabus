using System;
using System.Collections.Generic;

namespace DragRace
{
    class Program
    {
        /**
 * Take a look at the cars in this solution.
 * 1. Extract common behaviour to an interface called Car, and use it in the all classes.
 * Which methods will be extracted with an empty body, and which can be default?
 * 2. Create two more cars of your own choice.
 * 3. As you see there is a possibility to use some kind of boost in Lexus, extract it to a new interface
          and add that behaviour in one more car.
 * 4. Create one instance of an each car and add them to list.
 * 5. Iterate over the list 10 times, in the 3rd iteration use speed boost on the car if they have one.
 * 6. Print out the car name and speed of the fastest car
 */

        private static void Main(string[] args)
        {
            var audi = new Audi("Audi");
            var bmw = new Bmw("BMW");
            var cupra = new Cupra("Cupra");
            var hyundai = new Hyundai("Hyundai");
            var lexus = new Lexus("Lexus");
            var tesla = new Tesla("Tesla");

            List<ICar> raceCars = new List<ICar>();
            raceCars.Add(audi);
            raceCars.Add(bmw);
            raceCars.Add(cupra);
            raceCars.Add(hyundai);
            raceCars.Add(lexus);
            raceCars.Add(tesla);

            for (int i = 0; i < 10; i++)
            {
                foreach (var car in raceCars)
                {
                    if (i==2 && car is IBoost boost)
                        boost.UseNitrousOxideEngine();
                    else car.SpeedUp();
                }
            }

            var speed = 0;
            var name = "";
            foreach (var car in raceCars)
            {
                if (car.ShowCurrentSpeed() > speed)
                {
                    speed = car.ShowCurrentSpeed();
                    name = car.GetName();
                }
            }

            Console.WriteLine($"The fastest car is {name} with speed {speed}.");
            Console.ReadKey();
        }
    }
}