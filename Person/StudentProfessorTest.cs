using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop2;

namespace oop3.Person
{
    public class StudentProfessorTest
    {
        public void Main()
        {
            Console.WriteLine("Person Class");
            Person person = new Person("Nguyen Huu Thien");
            person.Greet();
            Console.WriteLine("Student Class");
            Student student = new Student("Nguyen Huu Thien");
            student.SetAge(15);
            student.Greet();
            student.ShowAge();

            Console.WriteLine("Teacher Class");
            Teacher teacher = new Teacher("Nguyen Huu Thien");
            teacher.SetAge(50);
            teacher.Greet();
            teacher.Explain();
        }
    }
}
