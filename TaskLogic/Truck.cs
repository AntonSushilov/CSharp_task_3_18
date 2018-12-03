using System;

namespace TaskLogic
{
    public class Truck : Car
    {
        public string Color { get; set; }
        public int LoadCapacity { get; set; }
        public Truck(int usefulwork, int spentwork, string model, int fuel, int maxspeed, string color, int loadcapacity) : base(usefulwork, spentwork, model, fuel, maxspeed)
        {
            Color = color;
            LoadCapacity = loadcapacity;
        }
        public override void Display()
        {
            {
                Console.WriteLine("Модель грузовика: " + Model + ", скорость: " + MaxSpeed + ", топливо:" + Fuel + ", цвет: " + Color);
            }
        }
    }
}
