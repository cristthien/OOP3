using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Animal
{
    public abstract class Animal
    {
        protected string _name;
        public Animal(string name) {
            this._name = name;
        }
        public string Name { get { return _name; } set { _name = value; } }
        public abstract void Eat();
    
    }
}
