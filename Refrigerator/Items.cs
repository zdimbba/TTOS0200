using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrigerator
{
    class Items
    {
        public string Name { get; set; }
        public Items(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return String.Format("Item: {0}", Name);
        }
    }
}
