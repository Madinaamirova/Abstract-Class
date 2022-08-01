using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double MaxSpeed { get; set; }
        public Car(string brand, string model, int year, string color) : base(year, color)
        {
            Brand = brand;
            Model = model;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Color:{Color} Year:{Year} Brand:{Brand} Model:{Model} ");
        }
    }
}
