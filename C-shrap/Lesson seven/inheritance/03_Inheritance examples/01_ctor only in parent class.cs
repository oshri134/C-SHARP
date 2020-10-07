using System;

namespace Lesson07
{

    class A
    {
        // constructor:
        public A()
        {
            Console.WriteLine("I am constructor of A");
        }
    }

    class B : A
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B(); // I am constructor of A

            Console.ReadKey();
        }
    }
}
