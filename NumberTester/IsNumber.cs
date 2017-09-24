using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTester
{
    class IsNumber
    {
        public static bool IsInt ()
        {
            //Ask for input
            Console.WriteLine("Give a number: ");
            string userinput = Console.ReadLine();

            int number;

            //Check if input is an integer
            if (int.TryParse(userinput, out number))
            {
                return true;
            }
           
            else
            {
                return false;
            }
        }

        public static bool IsDate()
        {
            //Ask for input
            Console.WriteLine("Give a number: ");
            string userinput = Console.ReadLine();

            DateTime date;

            //Check if input is a date
            if (DateTime.TryParse(userinput, out date))
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
