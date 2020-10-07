using System;

namespace Lesson07
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(12, 1, "John");
            Console.WriteLine(s1.ToString()); // Person id: 1, name: John NumOfClasses: 12
            Console.WriteLine(s1);            // Person id: 1, name: John NumOfClasses: 12

            Console.ReadKey();
        }
    }
}
