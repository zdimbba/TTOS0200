using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telkkari
{
    class Televisio
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private bool isOpen;
        public bool IsOpen
        {
            get
            {
                return isOpen;
            }
            set
            {
                isOpen = value;
                if (value == false)
                {
                    Channel = 0;
                    Volume = 0;
                }
            }
        }
        public int Channel { get; set; }
        public int Volume { get; set; }

        public override string ToString()
        {
            return "Brand: " + Brand + " Model: " + Model + " IsOpen: " + IsOpen + " Channel " + Channel + " Volume: " + Volume;
        }
    }
}
