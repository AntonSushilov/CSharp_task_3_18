using System;
using System.Collections.Generic;
using TaskLogic;

namespace CSharp_task_3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transport> list = new List<Transport>
            {
                new Truck(10,100, "Volvo",300,110,"Red", 1000),
                new Truck(20,100, "Kenworht",300,150,"Blue", 3000),
            };
            GetInfo(list);
            EfficiencyForAllTransport(list, new Truck(30, 100, "BMW", 300, 150, "Black", 5000));
            Console.ReadKey();
        }
        public static void GetInfo(List<Transport> list)
        {
            foreach (Transport so in list)
            {
                so.Display();
            }
        }
        public static void EfficiencyForAllTransport(List<Transport> list, Transport other)
        {
            foreach (Transport so in list)
            {
                Console.WriteLine(so.Efficiency(other.UsefulWork, other.SpentWork) + "%");
            }
        }
    }
}
