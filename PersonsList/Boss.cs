using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsList
{
    class Boss : Person
    {
        //Properties
        public int Bonus { get; set; }
        public string Car { get; set; }

        public Boss(string name, string prof, int sala, int bonus, string car) : base(name, prof, sala)
        {
            Bonus = bonus;
            Car = car;
        }

        public override string ToString()
        {
            return base.ToString() + "Bonus: " + Bonus + "\nCar: " + Car + "\n";
        }
    }
}
