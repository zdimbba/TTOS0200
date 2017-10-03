using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Boats : GenericInfo
    {
        //Properties
        public string Type { get; set; }
        public int Seats { get; set; }

        public Boats(string name, string model, int year, string color, string type, int seats) : base(name, model, year, color)
        {
            Type = type;
            Seats = seats;
        }
        public override string ToString()
        {
            return base.ToString() + " Type: " + Type + " Seats: " + Seats;
        }
    }
}
