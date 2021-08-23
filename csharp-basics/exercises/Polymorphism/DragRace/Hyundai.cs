using System;

namespace DragRace
{
    public class Hyundai : ICar
    {
        private int currentSpeed = 0;
        private string _name;

        public Hyundai(string name)
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

        public string StartEngine()
        {
            return "Rrrrrrr.....";
        }
        public string GetName()
        {
            return _name;
        }
    }
}