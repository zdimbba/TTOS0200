using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Still no clue about week
//Fishing stuff
//Timo Kannus
namespace FishermansFriend
{
    class Program
    {
        static void Main(string[] args)
        {
                try
                {
                    List<Fisher> Registry = new List<Fisher>();
                    Registry.Add(new Fisher("Kirsi Kernel", "020-12345678"));
                    Registry.Add(new Fisher("Fishy McFishface", "No phone number given"));
                    Registry[0].Catch.Add(new Fish("Barracuda", 2020, 150, "Jyväsjärvi"));
                    Registry[0].Catch.Add(new Fish("Whale", 10000, 15000, "Lake Saimaa"));
                    Registry[1].Catch.Add(new Fish("Pike", 1030, 55, "Päijänne"));
                    Registry[1].Catch.Add(new Fish("Bass", 1200, 50, "Keurusselkä"));
                    foreach (Fisher f in Registry)
                    {
                        Console.WriteLine("\nFisherman: {0} Phone: {1}", f.Name, f.PhoneNumber);
                        f.Catch.Sort((x, y) => y.Weight.CompareTo(x.Weight));
                        foreach (Fish r in f.Catch)
                        {
                            Console.WriteLine("-species: {0}\n-length(cm): {1}\n-weight(kg): {2}\n-location: {3}", r.Species, r.Length, r.Weight, r.Location);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
}