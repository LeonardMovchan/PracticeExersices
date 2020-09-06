using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    abstract class Figure
    {
        public abstract string FigureType { get; }

        public abstract double Perimeter();
        public abstract double Square();
        public abstract void GetInfo();
    }
}
