using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viikko 4, tehtävä 2
//Dynamon hissi
//Timo Kannus
namespace DynaHissi
{
    class Program
    {
        static void Main(string[] args)
        {
            int elevator = 0;
            //Create new elevator
            Hissi hissi = new Hissi();
            hissi.Floor = 1;
            //While loop for testing the output
            while (elevator < 5)
            {
                Console.WriteLine("Choose a floor: ");
                hissi.Floor = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Current floor is: " + hissi.Floor);
                elevator++;
            }
        }
    }
}
