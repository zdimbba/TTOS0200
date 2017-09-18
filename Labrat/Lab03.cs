using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 3
//Tee ohjelma, joka kysyy käyttäjältä kolme lukua ja tulostaa niiden summan ja keskiarvon.
//Timo Kannus
namespace Labrat
{
    class Lab03
    {
        public static void Lab013()
        {
            int luku1;
            int luku2;
            int luku3;
            int summa;
            int average;

            Console.Write("Anna ensimmäinen luku: ");
            luku1 = int.Parse(Console.ReadLine());

            Console.Write("Anna ensimmäinen luku: ");
            luku2 = int.Parse(Console.ReadLine());

            Console.Write("Anna ensimmäinen luku: ");
            luku3 = int.Parse(Console.ReadLine());

            summa = luku1 + luku2 + luku3;
            Console.WriteLine("Lukujen summa on: {0}", summa);

            average = summa / 3;
            Console.WriteLine("Lukujen keskiarvo: {0}", average);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
