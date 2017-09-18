using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 4
//Tee ohjelma, jossa kysytään käyttäjältä tämän ikä. 
//Jos ikä on alle 18 vuotta, tulosta "alaikäinen", jos se on 18-65 vuotta, tulosta "aikuinen", muussa tapauksessa tulosta "seniori".
//Timo Kannus
namespace Labrat
{
    class Lab04
    {
        public static void Lab014()
        {
            int ika;
            Console.Write("Anna ikäsi: ");
            ika = int.Parse(Console.ReadLine());

            if (ika >= 0 && ika <= 17)
            {
                Console.WriteLine("Olet alaikäinen");
            }
            if (ika >= 18 && ika <= 65)
            {
                Console.WriteLine("Olet aikuinen");
            }
            if (ika >= 66)
            {
                Console.WriteLine("Olet seniori");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
