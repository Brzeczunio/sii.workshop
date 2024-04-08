using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sii.Workshop.ClassLibrary
{
    public class Rectangle : Shape
    {
        private double A { get; set; }
        private double B { get; set; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public override double GetArea()
        {
            return A * B;
        }
    }
}
