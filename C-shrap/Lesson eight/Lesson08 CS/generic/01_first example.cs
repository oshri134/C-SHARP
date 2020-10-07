using System;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            isEqual(5, 8); // x = 5, y = 8
            isEqual("Hello","World"); // x = Hello, y = World
            isEqual(true, false); // x = True, y = False


            Console.ReadKey();
        }

        // generic: כללי
        static void isEqual<T>(T x, T y)
        {
            Console.WriteLine($"x = {x}, y = {y}");  
        }

    }
}