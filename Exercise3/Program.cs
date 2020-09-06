using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(5, 5);

            Circle circle = new Circle(10, 10, point);

            circle.GetInfo();
            Console.WriteLine();
            Triangle triangle = new Triangle(2, 2, 4);
            triangle.GetInfo();
            Console.WriteLine();
            Rectangle rectangle = new Rectangle(2, 2, 2, 2);

            rectangle.GetInfo();

            Console.ReadKey();
        }
    }
}
