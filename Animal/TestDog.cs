using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Animal
{
    public  class TestDog
    {
        public void Main() {
            Console.Write("Enter the name of dog: ");
            string name = Console.ReadLine()!;
            Dog dog = new Dog(name);
            Console.WriteLine("The dog's name is {0}", dog.Name);
            dog.Eat();


        }
    }
}
