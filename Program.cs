using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus = new Bus(23, 2002, "black");
            Car car = new Car("bmw", "x5", 2005, "black");
            Vehicle[] vehicles = new Vehicle[0];
            int a = 5;

            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = car;
            //vehicles[^1] = car;
            Array.Resize(ref vehicles, vehicles.Length + 1);
            vehicles[vehicles.Length - 1] = bus;
            foreach (var item in vehicles)
            {
                item.ShowInfo();
            }
        }
    }
}

