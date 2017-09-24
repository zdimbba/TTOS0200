using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Viikko 4, tehtävä 1.
//Staattiset metodit
//Timo Kannus
namespace NumberTester
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isnumber = NumberTester.IsNumber.IsInt();
            bool isdate = NumberTester.IsNumber.IsDate();

            Console.WriteLine("is a number: " + isnumber);
            Console.WriteLine("is a date: " + isdate);
        }
    }
}
