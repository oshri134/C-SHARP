using System;

namespace Lesson07
{
    class Bag
    {
        public static string Country;

        // regular constructor:
        public Bag(decimal price)
        {
            Console.WriteLine($"The bag price is: {price}");
        }

        // static constructor:
        static Bag()
        {
            Country = "USA";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // no instance was created:
            Console.WriteLine(Bag.Country); // USA

            Console.ReadKey();
        }
    }
}
