using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Circle : Figure
    {

        public Circle(double radiusX, double radiusY, Point center)
        {
            this.RadiusX = radiusX;
            this.RadiusY = radiusY;
            this.Center = center;
        }

        public double RadiusX { get; set; }
        public double RadiusY { get; set; }
        public Point Center { get; set; }

        public override string FigureType
        {
            get
            {
                if (RadiusX == RadiusY)
                {
                    return "Circle";
                }
                else return "Elipsis";
            }

        }

        public override double Perimeter()
        {
            double perimeter = 0;
            if(FigureType == "Circle") { 
            perimeter = 2 * Math.PI * RadiusX;
            }
            else
            {
                if(RadiusX > RadiusY) {
                    perimeter = 4 * ((Math.PI * RadiusX * RadiusY + (RadiusX - RadiusY))/ (RadiusX + RadiusY));
                }
                else
                {
                    perimeter = 4 * ((Math.PI * RadiusX * RadiusY + (RadiusY - RadiusX)) / (RadiusY + RadiusX));
                }
            }
            return perimeter;
        }

        public override double Square()
        {
            return Math.PI * RadiusX * RadiusY;

        }
    
        public override  void GetInfo()
        {
            Console.WriteLine($"The figure type is {FigureType}\nThe Perimeter is {Perimeter()}\nThe Square is {Square()}");

        }

        
    }
}
