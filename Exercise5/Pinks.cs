using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Pinks : Flower


    {
        public Pinks() { }
        public Pinks(int quantity)
        {
            this.Quantity = quantity;
        }

        private string name = "Pink";
        private decimal price = 9.500m;
        private int quantity = 1;
        public override string Name { get { return name; } set { name = value; } }
        public override decimal Price { get { return price * quantity; } set { price = value; } }
        public override int Quantity { get { return quantity; } set { quantity = value; } }
        public override string ToString()
        {
            return $"Flower: {name}\nPrice: {this.Price}";
        }

    }
}
