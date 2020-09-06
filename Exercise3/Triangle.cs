using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Triangle : Figure
    {
        public Triangle(int sideA, int sideB, int sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }

        public override string FigureType { get { return "Triangle"; } }

        public override double  Perimeter()
        {
            return SideA + SideB + SideC;
        }
        public override  double Square()
        {
            return Math.Sqrt(Perimeter() / 2 * ((Perimeter() / 2 - SideA) * (Perimeter() / 2 - SideB) * (Perimeter() / 2 - SideA)));
        }

        public override  void GetInfo()
        {
            Console.WriteLine($"The figure type is {FigureType}\nThe perimter of the triangle is {Perimeter()}\nThe Square is {Square()}");

        }

    }
}
