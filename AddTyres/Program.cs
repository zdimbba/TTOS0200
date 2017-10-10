using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viikko 6, tehtävä 1.
//Renkaita ajoneuvoon.
//Timo Kannus
namespace AddTyres
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicles car1 = new Vehicles("Porsche", "911");

            Console.WriteLine("Car {0} {1}", car1.Brand, car1.ToString());
            car1.AddTyre(new Tyres("Nokia", "Hakkapeliita"));
            car1.AddTyre(new Tyres("Nokia", "Hakkapeliita"));
            car1.AddTyre(new Tyres("Nokia", "Hakkapeliita"));
            car1.AddTyre(new Tyres("Nokia", "Hakkapeliita"));
        }
    }
}
