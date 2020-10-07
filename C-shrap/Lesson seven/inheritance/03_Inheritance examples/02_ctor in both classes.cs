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
        public B()
        {
            Console.WriteLine("I am constructor of B");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            /*
             * I am constructor of A
               I am constructor of B

            */
            Console.ReadKey();
        }
    }
}
