using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynaHissi
{
    class Hissi
    {
        //Properties
        private readonly int MinFloor = 1;
        private readonly int MaxFloor = 5;
        private int floor;
        public int Floor
        {
            get
            {
                return floor;
            }
            set
            {
                if (value >= MinFloor && value <= MaxFloor) floor = value;
                else
                {
                    Console.WriteLine("There are only five floors, try again");
                    floor = Floor;
                }
            }
        }
    }
}
