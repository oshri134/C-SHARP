using System;

namespace Lesson06
{
    // static class - we cannot create instances from. 
    // in static class - each member must be static (property, method, constructor)
    static class Food
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Console c1 = new Console(); -> we cannot create instance of static class Console

            Console.WriteLine(Math.Max(3, 7));

            // Math m1 = new Math(); -> we cannot create instance of static class Math

            Console.ReadKey();
        }
    }
}
