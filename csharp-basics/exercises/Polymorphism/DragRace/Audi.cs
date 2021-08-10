using System;

namespace DragRace
{
    public class Audi: ICar
    {
        private int currentSpeed = 0;
        private string _name;

        public Audi(string name)
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