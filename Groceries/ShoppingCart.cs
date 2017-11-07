using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Groceries
{
    class ShoppingCart
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public ShoppingCart(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
