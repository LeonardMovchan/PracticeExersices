using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
        static void Main(string[] args)
        {

            Point point1 = new Point()
            {
                X = 0,
                Y = 0
            };

            int radiusOne = 12;



            Point point2 = new Point(){
                X = 3,
                Y = 5
            };

            int radiusTwo = 11;

            Circle circle1 = new Circle(point1, radiusOne);

            double square1 = circle1.CircleSquare(circle1.Radius);

            Circle circle2 = new Circle(point2, radiusTwo);

            double square2 = circle2.CircleSquare(circle2.Radius);


           if(circle1.Equals(circle2))
            {
                Console.WriteLine("Circles one is equal to circle 2");
            }
            else
            {
                Console.WriteLine("Circles are not equal");
            }

            Console.WriteLine(square1);
            Console.WriteLine(square2);
            

            Console.ReadKey();
          
        }
    }
}
