using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTyres
{
    class Vehicles
    {
        //properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public Tyres[] Tyre { get; }
        private const int maxTyres = 4;
        private int countTyres = 0;

        public Vehicles(string brand, string model)
        {
            Tyre = new Tyres[maxTyres];
            Brand = brand;
            Model = model;
        }
        public void AddTyre(Tyres tyre)
        {
            if (countTyres < maxTyres)
            {
                Tyre[countTyres] = tyre;
                countTyres++;
                Console.WriteLine("Tyre {0} installed to vehicle {1}", tyre.ToString(), this.Brand);
            }
            else
            {
                Console.WriteLine("Can't install tyres.");
            }
        }
        public override string ToString()
        {
            string retval = "Manufacturer: " + Brand + " Model: " + Model + "\nTyres: ";
            foreach (Tyres tyre in Tyre)
            {
                if (tyre != null)
                {
                    retval += "\n" + tyre.ToString();
                }
            }
            return retval;
        }
    }
}
