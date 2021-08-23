using System;

namespace DragRace
{
    public class Lexus: ICar, IBoost
    {
        private int currentSpeed = 0;
        private string _name;

        public Lexus(string name)
        {
            _name = name;
        }
        
        public void SpeedUp() 
        {
            currentSpeed++;
        }

        public void SlowDown() 
        {
            currentSpeed--;
        }

        public int ShowCurrentSpeed() 
        {
            return currentSpeed;
        }

        public void UseNitrousOxideEngine() 
        {
            currentSpeed +=7;
        }

        public void StartEngine() 
        {
            Console.WriteLine("Rrrrrrr.....");
        }

        public string GetName()
        {
            return _name;
        }
    }
}