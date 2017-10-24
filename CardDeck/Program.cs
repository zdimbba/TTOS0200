using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Week 7 task 3.
//Korttipakka plus bonus.
//Timo Kannus
namespace CardDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck Pakka = new Deck();
            Pakka.CreateDeck(13);
            Pakka.ShowDeck();
            Console.WriteLine("\n*shuffle shuffle shuffle shuffle*\n");
            Pakka.Shuffle();
            Pakka.ShowDeck();
        }
    }
}