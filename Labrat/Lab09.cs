using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 9
//Tee ohjelma, joka kysyy käyttäjältä lukuja, kunnes hän syöttää luvun 0. Ohjelman tulee tulostaa syötettyjen lukujen summa.
//Timo Kannus
namespace Labrat
{
    class Lab09
    {
        public static void Lab019()
        {
            int luku;
            int summa = 0;
            for (int i = 0; ;)
            {
                Console.Write("Anna lukuja, nolla lopettaa: ");
                luku = int.Parse(Console.ReadLine());
                if (luku == 0)
                {
                    Console.WriteLine("Antamasi lukujen summa: " + summa);
                    break;
                }
                else
                {
                    summa += luku;
                }
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
