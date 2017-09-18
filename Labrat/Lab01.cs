using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 1:
//Tee ohjelma, joka tulostaa käyttäjän antamaa lukua (1, 2 tai 3) vastaavan luvun sanana.
//Timo Kannus
namespace Labrat
{
    class Lab01
    {
        public static void Lab011 ()
        {
            int luku;
            Console.Write("Anna luku 1, 2 tai 3: ");
            luku = int.Parse(Console.ReadLine());

            if(luku == 1)
            {
                Console.WriteLine("Annoit luvun yksi");
            }
            if (luku == 2)
            {
                Console.WriteLine("Annoit luvun kaksi");
            }
            if (luku == 3)
            {
                Console.WriteLine("Annoit luvun kolme");
            }
            if (luku == 0 | luku > 3)
            {
                Console.WriteLine("Lue ohjeet uudestaan");
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}