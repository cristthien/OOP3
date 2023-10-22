using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Shape
{
    public class TestShape
    {
        public void Main() {
            Circle circle = new Circle(2, 5, 8);
            Console.WriteLine( circle.ToString());
            Console.WriteLine("The area of circle is {0}", circle.Area());
            Console.WriteLine("The perimeter of circle is {0}", circle.Perimeter());
            Rectage rectange = new Rectage(2, 6, 8, 9);
            Console.WriteLine(rectange.ToString());
            Console.WriteLine("The area of rectage is {0}", rectange.Area());
            Console.WriteLine("The perimeter of rectage is {0}",rectange.Perimeter());
            
        }
    }
}
