using System;

namespace Lesson07
{

    class A
    {
        // constructor:
        public A(int num)
        {
            Console.WriteLine($"A, num = {num}");
        }

        // empty construcor - helps to not use the parent class's variables
        public A()
        {

        }
    }

    class B : A
    {
        public B(int x, int y):base(x)
        {
            Console.WriteLine($"B, x = {x}, y = {y}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B(4, 6);
            /*
             * 
             * A, num = 4
               B, x = 4, y = 6
            */
            Console.ReadKey();
        }
    }
}
