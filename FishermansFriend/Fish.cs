using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishermansFriend
{
    class Fish
    {
        public string Species { get; set; }
        public double Length { get; set; }
        public double Weight { get; set; }

        public string Location { get; set; }

        public Fish(string species, double length, double weight, string location)
        {
            Species = species;
            Length = length;
            Weight = weight;
            Location = location;
        }
    }
}