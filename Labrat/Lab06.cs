using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Tehtävä 6
//Auton kulutus on 7.02 litraa 100 kilometrin matkalla ja bensan hinta on 1.595 Euroa.
//Tee ohjelma, joka tulostaa ajetulla matkalla (kysytään käyttäjältä) kuluvan bensan määrän sekä bensaan menevän rahan määrän.
//Timo Kannus
namespace Labrat
{
    class Lab06
    {
        public static void Lab016()
        {

            double tulos;
            double kulutus;
            double kerroin;
            double matka;



            Console.Write("Anna matka kilometreinä: ");
            matka = double.Parse(Console.ReadLine());
            kerroin = matka / 100;
            kulutus = kerroin * 7.02;
            tulos = kulutus * 1.595;

            Console.WriteLine("Polttoaineen kulutus: " + kulutus + " Polttoaineen hinta: " + tulos);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
