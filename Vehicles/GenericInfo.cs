using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class GenericInfo
    {
        //Properties
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public GenericInfo(string name, string model, int year, string color)
        {
            Name = name;
            Model = model;
            Year = year;
            Color = color;
        }
        public override string ToString()
        {
            return "Name: " + Name + " Model: " + Model + " Year: " + Year + " Color: " + Color;
        }
    }
}
