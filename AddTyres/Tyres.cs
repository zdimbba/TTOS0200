using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTyres
{
    class Tyres
    {
        //properties
        public string Brand { get; set; }
        public string Size { get; set; }

        public Tyres(string brand, string size)
        {
            Brand = brand;
            Size = size;
        }
        public override string ToString()
        {
            return String.Format("Brand: {0}, Size: {1}", Brand, Size);
        }
    }
}
