using System;
/*
 * Esan ensimmäinen testi ohjelma
 * 9.1.2017 */
namespace Hello
{
    class Henkilo {
        public string Nimi { get; set; }
        public int Ika { get; set; }
    }
    class Testi
    {
        static void Main(string[] args)
        {
            //SayHello();
            ShowNames();
        }

        static void ShowNames()
        {
            //TODO
            //Tee ohjelma joka kysyy käyttäjältä viisi käyttäjänimeä ja tallentaa ne taulukkoon.
            //Ohjelma voisi tulostaa annetut nimet konsolille aakkosjärjestyksessä.
            //kysytään nimet
            string[] nimet = new string[5];
            for (int i = 0; i < nimet.Length ; i++)
            {
                Console.WriteLine("Anna nimi:");
                nimet[i] = Console.ReadLine();
            }
            //näytetään nimet
            Console.WriteLine("Annetut nimet olivat:");
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine(nimet[i]);
            }
            //sortataan ja näytetään
            Console.WriteLine("Annetut nimet aakkosjärjetyksessä ovat:");
            Array.Sort(nimet);
            for (int i = 0; i < nimet.Length; i++)
            {
                Console.WriteLine(nimet[i]);
            }

            //lopetus
            Console.WriteLine("Ohjelma suoritettu onnistuneesti!");
        }
        static void SayHello()
        {
            //määritellään muuttuja 
            string nimi = "Jack Russell";
            //luodaan olio Henkilo-luokasta
            Henkilo hlo = new Henkilo();
            hlo.Ika = 42;
            hlo.Nimi = "Max Mickelson";
            //konsolille
            Console.WriteLine("Terve: {0} ikäsi on: {1}", hlo.Nimi, hlo.Ika);

        }
    }
}
