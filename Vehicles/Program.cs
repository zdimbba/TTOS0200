using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viikko 5, tehtävä 5
//Erilaisia ajoneuvoja
//Timo Kannus
namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new vehicels
            Bikes bike1 = new Bikes("Jopo", "Basic", 1987, "Yellow", false, "None");
            Bikes bike2 = new Bikes("Tunturi", "Mountaineer", 2012, "White", true, "Super");
            Boats boat1 = new Boats("Buster", "-", 1995, "Silver", "Motorboat", 4);

            //Print out the vehicles
            Console.WriteLine(bike1.ToString());
            Console.WriteLine(bike2.ToString());
            Console.WriteLine(boat1.ToString());
        }
    }
}
