using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    abstract class Flower
    {
        public abstract string Name { get; set; }
        public abstract decimal Price { get; set;}
        public abstract int Quantity { get; set; }
    }
}
