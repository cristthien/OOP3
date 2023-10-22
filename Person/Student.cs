using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Person
{
    public class Student : Person
    {
        public Student(string name) : base(name)
        {
        }
        public void ShowAge() {

            Console.WriteLine("My age is: {0} years old", _age);
        } 
    }
}
