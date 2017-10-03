using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonsList
{
    class Person
    {
        //Properties
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }

        public Person(string name, string prof, int sala)
        {
            Name = name;
            Profession = prof;
            Salary = sala;
        }

        public override string ToString()
        {
            return "Name: " + Name + "\nProfession: " + Profession + "\nSalary: " + Salary + "\n";
        }
    }
}
