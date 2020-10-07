using System;
using System.Runtime.InteropServices;

namespace Lesson07
{

    class A
    {
        public int item1 = 1;
    }

    class B : A
    {
        public int item2 = 5;
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new B(); // a1 can access only to A class
            a1.item1 = 32;

            B b1 = new B(); // b1 can access both A and B classes
            b1.item1 = 5;
            b1.item2 = 34;

            Console.ReadKey();
        }
    }
}
