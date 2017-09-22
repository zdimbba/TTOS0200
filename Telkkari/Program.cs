using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telkkari
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new TV
            Televisio televisio = new Televisio();
            televisio.Brand = "TCL";
            televisio.Model = "Melko uusi";
            televisio.IsOpen = false;
            Console.WriteLine(televisio.ToString());

            //Televisio päälle
            televisio.IsOpen = true;
            televisio.Channel = 75;
            televisio.Volume = 9;
            Console.WriteLine(televisio.ToString());

            //Televisio kiinni
            televisio.IsOpen = false;
            Console.WriteLine(televisio.ToString());

            //Lopetus
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();
        }
    }
}
