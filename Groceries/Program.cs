using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Week ??
//Grocery shopping
//Timo Kannus
namespace Groceries
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<ShoppingCart> Shoppingcart = new List<ShoppingCart>();
                Shoppingcart.Add(new ShoppingCart("Milk", 1.4));
                Shoppingcart.Add(new ShoppingCart("Yoghurt", 0.8));
                Shoppingcart.Add(new ShoppingCart("Cigarettes", 7.1));
                Shoppingcart.Add(new ShoppingCart("Cereal", 2.5));
                Console.WriteLine("All products in collection: ");
                foreach (ShoppingCart p in Shoppingcart)
                {
                    Console.WriteLine("- product: {0} {1} e", p.Name, p.Price);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}