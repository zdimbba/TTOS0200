using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Bikes : GenericInfo
    {
        //Properties
        public bool Gears { get; set; }
        public string GearName { get; set; }

        public Bikes(string name, string model, int year, string color, bool gears, string gearName) : base(name, model, year, color)
        {
            Gears = gears;
            GearName = gearName;
        }
        public override string ToString()
        {
            return base.ToString() + " Gears: " + Gears + " Gear Name: " + GearName;
        }
    }
}
