using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 5
//Tee ohjelma, joka näyttää annetun sekuntimäärän tunteina, minuutteina ja sekunteina. Aikamääre sekuntteina kysytään käyttäjältä.
//Timo Kannus
namespace Labrat
{
    class Lab05
    {
        public static void Lab015()
        {
            int luku;
            int tunti;
            int minute;
            int second;
            int jaannos;

            Console.Write("Anna sekuntimäärä: ");
            luku = int.Parse(Console.ReadLine());
            tunti = luku / 3600;
            jaannos = luku % 3600;
            minute = jaannos / 60;
            second = minute % 60;

            Console.WriteLine("Tunnit  " + tunti + " Minuutit " + minute + " Sekunnit " + second);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
