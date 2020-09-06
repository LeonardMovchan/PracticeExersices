using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class FlowerManager
    {
        private static List<Flower> _flowersBouquet = new List<Flower>();

        public static void Add(Flower flower)
        {
            _flowersBouquet.Add(flower);
        }

        public static Flower[] GetFlowers()
        {
            return _flowersBouquet.ToArray();
        }

        public static decimal TotalPrice()
        {
            decimal totalPrice = 0;

            for (int i = 0; i < GetFlowers().Length; i++)
            {
                totalPrice += _flowersBouquet[i].Price;
            }
            return totalPrice;
        }


    }

}
