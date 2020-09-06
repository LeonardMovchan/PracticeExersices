using System;

namespace Practice_10
{
    class Program
    {
        static void Main(string[] args)
        {

            Point a = new Point()
            {
                X = 50,
                Y = 30
            };

            Point b = new Point()
            {
                X = 100,
                Y = 30  
            };
            Point c = new Point()
            {
                X = 20,
                Y = 10
            };
            Point d = new Point()
            {
                X = 130,
                Y = 10
            };

            Trapezoid trapezoid = new Trapezoid(a, b, c, d);


            trapezoid.GetInfo();

            TrapezoidKeep.Add(trapezoid);
           
            
            if (trapezoid.IsTrapezoid())
            {
                Console.WriteLine("Is trapezoid");
            }
            else Console.WriteLine("Is not trapezoid");

            Console.ReadKey();

        }


    
    }
}
