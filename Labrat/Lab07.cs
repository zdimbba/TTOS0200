using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 7
//Tee ohjelma, joka näyttää onko annettu vuosi karkausvuosi. Vuosiluku kysytään käyttäjältä.
//Timo Kannus
namespace Labrat
{
    class Lab07
    {
        public static void Lab017()
        {
            int luku;

            Console.Write("Anna vuosi: ");
            luku = int.Parse(Console.ReadLine());

            if (luku % 4 > 0)
            {
                Console.WriteLine("Vuosi ei ole karkausvuosi.");
            }
            if (luku % 4 == 0)
            {
                if (luku % 100 == 0)
                {
                    if (luku % 400 == 0)
                    {
                        Console.WriteLine("Vuosi on karkausvuosi.");
                    }
                    else
                    {
                        Console.WriteLine("Vuosi ei ole karkausvuosi.");
                    }
                }
                else
                {
                    Console.WriteLine("Vuosi on karkausvuosi.");
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
