using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Animal
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public override void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
}
