using System;

namespace lesson01
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation - שרבוב
            int age = 34;
            string name = "John";

            Console.WriteLine($"User: {name}, is {age} years old");

            Console.WriteLine($"4 * 5 = {4 * 5}");

            Console.ReadKey();

        }
    }
}
