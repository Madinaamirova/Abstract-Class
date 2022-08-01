using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class Vehicle
    {
        public int Year { get; set; }
        public string Color { get; set; }

        public Vehicle(int year, string color)
        {
            Color = color;
            Year = year;
        }

        public abstract void ShowInfo();
    }
}
