using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Shape
{
    public class Rectage : Shape
    {
        protected double side1;
        protected double side2;
        public Rectage(double x, double y, double side1, double side2) : base(x, y)
        {
            this.side1 = side1;
            this.side2 = side2;
        }

        public override double Area()
        {
            return side1 * side2;
        }

        public override double Perimeter()
        {
            return (side2 * 2 )+ (side1 * 2);
        }
    }
}
