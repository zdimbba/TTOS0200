using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Tehtävä 11
Tee kahden sisäkkäisen for-silmukan avulla ohjelma, joka tulostaa seuraavanlaisen kuvion:
*
**
***
****
*****

Käyttäjä antaa syötteenä tähtirivien lukumäärän.Yllä olevassa esimerkissä käyttäjä on syöttänyt luvun 5.*/
//Timo Kannus
namespace Labrat
{
    class Lab11
    {
        public static void Lab0111()
        {
            int luku;
            Console.Write("Anna tähtirivien määrä: ");
            luku = int.Parse(Console.ReadLine());

            for (int i = 1; i <= luku; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
