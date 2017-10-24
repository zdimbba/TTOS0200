using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Week 7 task 2.
//CD-levy jutska.
//Timo Kannus
namespace CDLibrary
{
    class Program
    {
        static void ListAlbum()
        {
            Disc cd1 = new Disc("Love and Other Disasters", "Sonic Syndicate");
            cd1.AddTrack(new Track("Encaged", "4:26"));
            cd1.AddTrack(new Track("Hellgate: Worcester", "3:23"));
            cd1.AddTrack(new Track("Jack of Diamonds", "3:41"));
            cd1.AddTrack(new Track("My Escape", "4:10"));
            cd1.AddTrack(new Track("Fallout", "3:51"));
            cd1.AddTrack(new Track("Power shift", "3:32"));
            cd1.AddTrack(new Track("Contradiction", "3:32"));
            cd1.AddTrack(new Track("Damage Control", "3:49"));
            cd1.AddTrack(new Track("Red Eyed Friend", "4:43"));
            cd1.AddTrack(new Track("Affliction", "5:11"));
            Console.WriteLine(cd1.ToString());
        }
        static void Main(string[] args)
        {
            ListAlbum();
        }
    }
}