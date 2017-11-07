using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishermansFriend
{
    class Fisher
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Fish> Catch { get; set; }
        public Fisher(string name, string phonenumber)
        {
            Name = name;
            PhoneNumber = phonenumber;
            Catch = new List<Fish>();
        }
    }
}
