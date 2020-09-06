using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Roses : Flower
    {

        public Roses() { }
        public Roses(int quantity)
        {
            this.Quantity = quantity;
        }

        private string name = "Rose";
        private decimal price = 10.20m;
        private int quantity = 1;
        public override string Name { get { return name; } set { name = value; } }
        public override decimal Price { get { return price; } set { price = value; } }
        public override int Quantity { get { return quantity; } set{ quantity = value; } }
        public override string ToString()
        {
            return $"Flower: {name}\nPrice: {this.Price}";
        }

    }
}
