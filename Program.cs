using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    Person person = new Person();
    person.Name = "Mike";
    person.Age = 20;
    person.GetNameAndAge();

    Teacher teacher = new Teacher();
    teacher.Name = "Thomas";
    teacher.Age = 35;
    teacher.TeacherId = "190302";
    teacher.Subject = "Math";
    teacher.GetNameAndAge();

    Student student = new Student();
    student.Name = "Sara";
    student.Age = 19;
    student.StudentId = "10506";
    student.Email = "sara1234@amikom.ac.id";
    student.GetNameAndAge();

    Console.ReadKey();
}
