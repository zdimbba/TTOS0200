using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Lost track of weeks
//A dice
//Timo Kannus
namespace ThrowDice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dice dice = new Dice();
                Console.WriteLine("How many times would you like to throw?: ");
                int throwamount = int.Parse(Console.ReadLine());
                dice.Throw(throwamount);
                dice.Print();
                Console.WriteLine("Average: " + dice.Throws.Average());
                for (int x = 1; x < 7; x++)
                {
                    int count = 0;
                    foreach (int i in dice.Throws)
                    {
                        if (i == x)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("{0} came up: {1} times.", x, count);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
