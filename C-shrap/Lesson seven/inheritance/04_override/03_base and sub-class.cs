using System;
using System.Runtime.InteropServices;

namespace Lesson07
{

    class A
    {
    }

    class B : A
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A(); // Good!

            A a2 = new B(); // base class can point to sub-class

            B b1 = new B(); // Good!

            // B b2 = new A(); -> Error! sub-class cannot point to base-class


            Console.ReadKey();
        }
    }
}
