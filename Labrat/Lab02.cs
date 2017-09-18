using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labrat
{
    class Lab02
    {
        public static void Lab012 ()
        {
            int luku;
            Console.Write("Anna saamasi pisteet: ");
            luku = int.Parse(Console.ReadLine());

            if (luku == 0 | luku == 1)
            {
                Console.WriteLine("Arvosanasi on 0");
            }
            if (luku == 2 | luku == 3)
            {
                Console.WriteLine("Arvosanasi on 1");
            }
            if (luku == 4 | luku == 5)
            {
                Console.WriteLine("Arvosanasi on 2");
            }
            if (luku == 6 | luku == 7)
            {
                Console.WriteLine("Arvosanasi on 3");
            }
            if (luku == 8 | luku == 9)
            {
                Console.WriteLine("Arvosanasi on 4");
            }
            if (luku >= 10 && luku < 13)
            {
                Console.WriteLine("Arvosanasi on 5");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}