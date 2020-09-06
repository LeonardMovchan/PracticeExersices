using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    class Rectangle : Figure
    {

       public Rectangle(int sideA, int sideB, int sideC, int sideD)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
            this.SideD = sideD;
        }

        public int SideA { get; set; }
        public int SideB { get; set; }
        public int SideC { get; set; }
        public int SideD { get; set; }

        public override  string FigureType
        {
            get
            {
                if (SideA == SideC && SideB == SideD)
                {
                    if (SideA == SideB)
                    {
                        return "Square";
                    }
                    else
                    {
                        return "Rectangle";
                    }
                }
                else
                {
                    return "Not a square nor a rectangle";
                }
            }
        }

        public override double Perimeter()
        {
            return (SideA + SideB) * 2;
        }

        public override double Square()
        {
            return SideA * SideB;

        }

        public override void GetInfo()
        {
            Console.WriteLine($"The figure type is {FigureType}\nThe Perimeter is {Perimeter()}\nThe Square(area) is {Square()}");

        }
    }
}
