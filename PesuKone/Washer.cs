using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesuKone
{
    class Washer
    {
        //Properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public int SpinSpeed { get; set; }
        public int LaundryAmount { get; set; }

        public Washer ()
        {

        }

        public Washer (string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public void AddLaundry (int laundry)
        {
            LaundryAmount += laundry;
        }

        public void RemoveLaundry ()
        {
            LaundryAmount = 0;
        }

        public override string ToString()
        {
            return "Brand: " + Brand + " Model: " + Model + " SpinSpeed: " + SpinSpeed + " LaundryAmount: " + LaundryAmount;
        }
    }
}
