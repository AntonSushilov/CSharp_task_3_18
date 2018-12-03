namespace TaskLogic
{
    public abstract class Car : Transport
    {
        public int UsefulWork { get; set; }
        public int SpentWork { get; set; }
        public string Model { get; set; }
        public int Fuel { get; set; }
        public int MaxSpeed { get; set; }
        public Car(int usefulwork, int spentwork, string model, int fuel, int maxspeed)
        {
            UsefulWork = usefulwork;
            SpentWork = spentwork;
            Model = model;
            Fuel = fuel;
            MaxSpeed = maxspeed;
        }
        public abstract void Display();
        public double Efficiency(int usefulwork, int spentwork) //эффективность
        {
            return UsefulWork * 100 / SpentWork;
        }

        public double FuelConsumption(Car other)
        {
            double efficiency = UsefulWork / SpentWork;
            return efficiency * other.Fuel;
        }
    }
}
