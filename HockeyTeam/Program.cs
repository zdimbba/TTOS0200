using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Week 7 task 4.
//Jääkiekkojoukkue...(toim. huom. En seuraa jääkiekkoa, joten joukkueeni on kuvitteellinen).
//Timo Kannus
namespace HockeyTeam
{
    class Program
    {
        static void Main(string[] args)
        {
            Team something = new Team("Generic", "Somethingville");
            Console.WriteLine(something.ToString());
            List<Player> players = new List<Player>();
            players.Insert(0, new Player() { FirstName = "Random", LastName = "Ricky", Hand = "R", JerseyNumber = 10 });
            players.Insert(1, new Player() { FirstName = "Some", LastName = "Guy", Hand = "R", JerseyNumber = 11 });
            players.Insert(2, new Player() { FirstName = "Nobody", LastName = "Knows", Hand = "L", JerseyNumber = 12 });
            players.Insert(3, new Player() { FirstName = "Lost", LastName = "Soul", Hand = "L", JerseyNumber = 13 });
            players.Insert(4, new Player() { FirstName = "Darn", LastName = "Hippie", Hand = "L", JerseyNumber = 14 });
            players.Insert(5, new Player() { FirstName = "Another", LastName = "Player", Hand = "R", JerseyNumber = 15 });
            foreach (Player play in players)
            {
                Console.WriteLine(play);
            }
            players.Insert(6, new Player() { FirstName = "Last", LastName = "Resort", Hand = "R", JerseyNumber = 27 });
            Console.WriteLine("\nAdded player:\n");
            foreach (Player play in players)
            {
                Console.WriteLine(play);
            }
            
            players.RemoveAt(5);
            Console.WriteLine("\nRemoved player:\n");
            foreach (Player play in players)
            {
                Console.WriteLine(play);
            }
        }
    }
}