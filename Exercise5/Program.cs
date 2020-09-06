using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {

            Flower roses = new Roses(1);
            Flower pinks = new Pinks(2);
            Flower tulips = new Tulips(1);

            FlowerManager.Add(roses);
            FlowerManager.Add(pinks);
            FlowerManager.Add(tulips);

           
            Console.WriteLine($"The total price of the bouquet is {FlowerManager.TotalPrice()}");

            

            Console.ReadKey();
        }
    }
}
