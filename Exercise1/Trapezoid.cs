using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_10
{
    class TrapezoidKeep
    {
        public static List<Trapezoid> _trapezoid = new List<Trapezoid>();

        public static void Add(Trapezoid trapezoid)
        {
            _trapezoid.Add(trapezoid);
        }
    }

    class Trapezoid
    {
        public Trapezoid(Point a, Point b, Point c, Point d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }
  
        public Point A { get; set; }
        public Point B { get; set; }
        public Point C { get; set; }
        public Point D { get; set; }



        public double AB => SideCalculator(A, B);
        public double BC => SideCalculator(B, C);
        public double CD => SideCalculator(C, D);
        public double AD => SideCalculator(A, D);


        public  bool IsTrapezoid()
        {
            return koef(A, B) == koef(C, D) || koef(C, A) == koef(D, B);
        }
        static float koef(Point p1, Point p2)
        {
            if (p1.X == p2.X)
                return float.PositiveInfinity;
            return (float)(p1.Y - p2.Y) / (float)(p1.X - p2.X);
        }

        private double SideCalculator(Point p1, Point p2)
        {
            return Math.Sqrt(Math.Pow((p2.X - p1.X), 2)) + (Math.Pow((p2.Y - p1.Y), 2));
        }

        private double GetPerimeter()
        {
            return AB + BC + CD + AD;
        }

        private double GetSquare()
        {
            return ((AB + BC) / 2) * Math.Sqrt(Math.Pow(CD, 2) - Math.Sqrt(Math.Pow((BC - AB), 2) + Math.Pow(CD, 2) - Math.Pow(AD, 2)) / 2 * (AB - BC));
        }
        public void GetInfo()
        {
            // TODO: Finish output all data
            Console.WriteLine($"Side A: {AB}\nSide B: {BC}\nSide C: {CD}\nSide D: {AD}\nPerimter: {GetPerimeter()}");

        }
        

        public override string ToString()
        {
            return $"Side A: {this.A}\nSide B: {this.B}\nSide C: {this.C}\nSide A {this.D}";
        }
    }
}
