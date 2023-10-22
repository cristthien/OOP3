using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Shape
{
    public struct Location {
        private double x;
        private double y; 
        public Location(double x, double y)
        {
            this.x = x;
            this.y = y;

        }
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }
    }
    public abstract class Shape
    {
        protected Location c;
        public Shape(double x, double y) { 
            c = new Location(x, y);
        } 
        public override string ToString()
        {
            return String.Format("x= {0} y= {1}", c.X, c.Y);
        }
        public abstract double Area();
        public abstract double Perimeter();


    }
}
