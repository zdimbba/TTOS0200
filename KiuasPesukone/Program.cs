using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiuasPesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new kiuas.
            Kiuas kiuas = new Kiuas();

            kiuas.Power = true;
            kiuas.Temperature = 95;
            kiuas.Moisture = 60;

            //Print the values
            Console.WriteLine("Onko kiuas päällä: {0}", kiuas.Power);
            Console.WriteLine("Kiukaan lämpötila: {0}", kiuas.Temperature);
            Console.WriteLine("Kiukaan kosteus {0}", kiuas.Moisture);
        }
    }
}
