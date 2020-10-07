using System;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person -> Student
            Person p1 = new Person(); // can work!

            Student s1 = new Student();
            s1.Name = "John"; // property from father class
            s1.AvgGrade = 99.9f; // property from child class

            Console.ReadKey();
        }
    }
}
