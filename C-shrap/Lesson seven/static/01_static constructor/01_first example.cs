using System;

namespace Lesson07
{
    class Bag
    {
        // regular constructor:
        public Bag(decimal price)
        {
            Console.WriteLine($"The bag price is: {price}");
        }

        // static constructor:
        static Bag()
        {
            Console.WriteLine("static constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bag b1 = new Bag(30.5m);
            Bag b2 = new Bag(19.5m);

            /*
                static constructor
                The bag price is: 30.5
                The bag price is: 19.5

            */


            Console.ReadKey();
        }
    }
}
