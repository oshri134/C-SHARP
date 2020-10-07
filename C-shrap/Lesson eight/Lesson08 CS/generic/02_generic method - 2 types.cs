using System;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            // generic methods - use T and S as default. 
            // we can use diffrent types, or the same types
            func(5, "heello"); 
            func("heello", 5);
            func("heello", "world");


            Console.ReadKey();
        }

        // generic: כללי
        static void func<T, S>(T x, S y)
        {
            Console.WriteLine($"x = {x}, y = {y}");  
        }

    }
}