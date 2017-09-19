using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 8
//Tee ohjelma, joka kysyy käyttäjältä 3 kokonaislukua ja tulostaa niistä suurimman.
//Timo Kannus
namespace Labrat
{
    class Lab08
    {
        public static void Lab018()
        {
            int luku1;
            int luku2;
            int luku3;

            Console.WriteLine("Anna ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna toinen luku: ");
            luku2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Anna kolmas luku: ");
            luku3 = int.Parse(Console.ReadLine());

            if (luku1 > luku2)
            {
                if (luku1 > luku3)
                {
                    Console.WriteLine("Ensimmäinen luku on suurin: " + luku1);
                }
                else
                {
                    Console.WriteLine("Kolmas luku on suurin: " + luku3);
                }
            }
            else if (luku2 > luku3)
            {
                Console.WriteLine("Toinen luku on suurin: " + luku2);
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}