using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Shape
{
    public class Circle : Shape
    {
        protected double radius;
        public Circle(double x, double y, double radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return radius * radius * 3.14;
        }

        public override double Perimeter()
        {   return 2* radius * 3.14;
        }
    }
}
