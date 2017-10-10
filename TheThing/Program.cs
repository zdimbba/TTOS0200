using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheThing
{
    class Thing
    {   //julkinen jäsenmuuttuja !=ominaisuus
        //public string Name;

        //parempi vaihtoehto, ominaisuus AutoImplemented Propertyn avulla
        //public string Name { get; set; }
        //ToString -method käyttää jäsenmuuttujaa tai propertyä.

            //propfull + tab
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //Constructors
        public Thing()
        {
            name = "Nobody";
        }

        public override string ToString()
        {
            //return "My name is: " + Name;

            //mielummin sisäistä muuttujaa:
            return "My name is: " + name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thing t = new Thing();
            t.Name = "Something";
            Console.WriteLine(t.Name);
            Console.WriteLine(t.ToString());
        }
    }
}
