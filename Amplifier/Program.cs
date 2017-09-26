using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viikko 4, tehtävä 3.
//Yksinkertainen vahvistin
//Timo Kannus
namespace Amplifier
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial value for the while loop
            int tester = 0;
            //Create new amplifier
            Amplify doohickey = new Amplify();
            doohickey.Volume = 0;
            //While loop for testing the output
            while (tester < 5)
            {
                Console.WriteLine("Give desired volume: ");
                doohickey.Volume = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Volume is set to: " + doohickey.Volume);
                tester++;
            }
        }
    }
}
