using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keThuaExample
{
    internal class Circle:Shape
    {
        public double Radius { get; set; }

        public Circle() 
        {
            Radius = 1.0f;
        }

        public Circle(string color, Boolean filled, double radius):base(color, filled)
        {

        }
        public double GetArea()
        {
            return 2* Math.PI * Radius;
        }

        public double GetPerimeter()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override string ToString()
        {
            return $" A circle with radius = {Radius}, which is a subclass of {base.ToString()} ";
        }
    }
}
