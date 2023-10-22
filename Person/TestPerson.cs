using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop3.Person
{
    public class TestPerson
    {
        public void Main() {

            Person[] people = new Person[3];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new Person(String.Format("User {0}", i));
            }
            foreach (Person person in people)
            {
                Console.WriteLine(person.ToString());
            }
        }

    }
}
