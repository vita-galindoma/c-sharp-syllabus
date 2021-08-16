namespace FuelConsumptionCalculator
{
    public class Car
    {
        double currentMileage;
        double liters; // Liters of gas used between the readings


        public Car(double startOdo)
        {
            this.currentMileage = startOdo;
        }

        public double CalculateConsumption()
        { 
            return this.liters / this.currentMileage;

        }

        private double ConsumptionPer100Km()
        {
            return 100 * CalculateConsumption();
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
            this.currentMileage = mileage;
            this.liters =+ liters;
        }
    }
}
