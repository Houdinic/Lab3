using System;

namespace Exercise4
{
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Greeting();
            Student student = new Student();
            student.SetAge(21);
            student.Greeting();
            student.ShowAge();
            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greeting();
            teacher.Explain();
        }
    }
}
