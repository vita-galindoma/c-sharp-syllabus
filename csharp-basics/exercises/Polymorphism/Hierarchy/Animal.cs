using System;


namespace Hierarchy
{
    public abstract class Animal
    {
        private string _animalName;
        private string _animalType;
        private double _animalWeight;
        private int _foodEaten;

        public string AnimalName
        {
            get => _animalName;
            set => _animalName = value;
        }
        public double AnimalWeight
        {
            get => _animalWeight;
            set => _animalWeight = value;
        }

        public string AnimalType
        {
            get => _animalType;
            set => _animalType = value;
        }

        public int FoodEaten
        {
            get => _foodEaten;
            set => _foodEaten = value;
        }

        protected Animal(string animalName, string animalType, double animalWeight, int foodEaten)
        {
            _animalName = animalName;
            _animalType = animalType;
            _animalWeight = animalWeight;
            _foodEaten = foodEaten;
        }

        public abstract string MakeSound();
        public abstract string Eat(Food food);

        public virtual string ReturnInfo()
        {
            var result =
                $"{_animalType} [{ _animalName}, { _animalWeight}, { _foodEaten}]";
            return result;
        }

    }
}
