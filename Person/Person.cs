using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Person
{
    public class Person
    {
        protected string _name;
        protected int _age = 0;
        public Person(string name)
        {
            this._name = name;

        }
        ~Person()
        {
   
            this._name = "";
            Console.WriteLine("Thien khung");
        }
        public override string ToString()
        {
            return String.Format("Person's name: {0}", _name);
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string value)
        {
            _name = value;
        }
        public void SetAge(int value)
        {
           this._age = value;
        }
        public void Greet() {
            Console.WriteLine("Hello, My name is {0}", _name) ;
        }
        
    }
}
