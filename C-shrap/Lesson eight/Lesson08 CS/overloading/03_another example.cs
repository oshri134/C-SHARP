using System;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isEqual(5, 5));
            Console.WriteLine(isEqual(true, false));
            Console.ReadKey();
        }

        // overloading with 2 variables: int, int
        static bool isEqual(int x, int y)
        {
            return x == y;
        }

        // overloading with 2 variables: bool, bool
        static bool isEqual(bool x, bool y)
        {
            return x == y;
        }
    }
}