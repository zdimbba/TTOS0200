using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesuKone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating the new washer
            Washer miele = new Washer();
            miele.Brand = "Miele";
            miele.Model = "Joku hieno";
            miele.SpinSpeed = 1600;
            miele.LaundryAmount = 4;
            miele.AddLaundry(3);
            Console.WriteLine(miele.ToString());

            miele.RemoveLaundry();
            Console.WriteLine(miele.ToString());

            //Just in case the program doesn't show the results
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

        }
    }
}
