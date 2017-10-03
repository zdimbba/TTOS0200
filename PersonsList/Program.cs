using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viikko 5, tehtävä 4
//Periytyviä tietoja henkilöstössä
//Timo Kannus
namespace PersonsList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create new staff
            Person anna = new Person("Anna Kekkonen", "Cleaning person", 700);
            Boss lasse = new Boss("Lasse Mortensen", "Uberboss", anna.Salary * 500, 6000, "Volkswagen");
            //Print staff
            Console.WriteLine(anna.ToString() + "\n" + lasse.ToString());
            anna.Profession = "Designated cleaning person";
            anna.Salary = 750;
            Console.WriteLine(anna.ToString());
        }
    }
}
