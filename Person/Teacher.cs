using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Person
{
    public class Teacher : Person
    {
        public Teacher(string name) : base(name)
        {

        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");

        }
    }
}
