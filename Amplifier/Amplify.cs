using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amplifier
{
    class Amplify
    {
        //Properties
        private readonly int MaxVolume = 100;
        private int volume;
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= MaxVolume) volume = value;
                else
                {
                    volume = MaxVolume;
                }
            }
        }
    }
}
