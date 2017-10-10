using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viikko 6, tehtävä 2.
//Jääkaappi
//Timo Kannus
namespace Refrigerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Content helkama = new Content();
            helkama.OpenDoor();
            Items someday = new Items("Milk");
            Items yesterday = new Items("Miscellaneous");
            Items today = new Items("Something edible");

            helkama.AddItems(someday);
            helkama.AddItems(yesterday);
            helkama.AddItems(today);

            Console.WriteLine(helkama.ToString());
        }
    }
}
