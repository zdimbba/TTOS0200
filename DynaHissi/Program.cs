using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaHissi
{
    class Program
    {
        static void Main(string[] args)
        {
            int elevator = 0;

            Hissi hissi = new Hissi();
            hissi.Floor = 1;

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
