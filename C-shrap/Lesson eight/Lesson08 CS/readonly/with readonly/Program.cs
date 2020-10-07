using System;

namespace Lesson08
{
    class Program
    {
        static void Main(string[] args)
        {
            // any property can be changed(if public)
            Home h1 = new Home(5);

            Console.WriteLine(h1); // Home from Israel, has: 6 rooms

            // Home.Country = "USA"; -> Error!

            Console.ReadKey();
        }
    }
}