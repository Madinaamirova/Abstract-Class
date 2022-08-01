using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Bus : Vehicle
    {
        public int PassengerCount { get; set; }
        public Bus(int passengerCount, int year, string color) : base(year, color)
        {
            PassengerCount = passengerCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Color:{Color} Year:{Year} PassengerCount:{PassengerCount}");
        }
    }
}
