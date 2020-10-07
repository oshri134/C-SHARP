using System;

namespace Lesson08
{
    class Person { } // parent class
    class Student : Person { }

    class Home { }


    class Program
    {

        // T - must be object of class Person or subclasses of Person (here: Student)
        static void func<T>(T x) where T : Person
        {
            Console.WriteLine($"x = {x}");
        }

        static void Main(string[] args)
        {
            func(new Person()); // works!

            func(new Home());// -> Error!

            func(new Student()); 

            Console.ReadKey();
        }

    

    }
}