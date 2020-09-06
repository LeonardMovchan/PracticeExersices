using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        public Point CenterPoint { get; set; }
        public int Radius { get; set; }

        public Circle(Point point, int radius)
        {
            CenterPoint = point;
            Radius = radius;
        }

        public double CircleSquare(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override bool Equals(object obj)
        {
            var cirlce = obj as Circle;
            return CircleSquare(Radius) == cirlce.CircleSquare(cirlce.Radius);
                      
        }


    }
}
