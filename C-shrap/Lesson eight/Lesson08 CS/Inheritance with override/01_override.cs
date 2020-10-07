using System;

namespace Lesson08
{
    class A
    {
        // method:
        public void x()
        {
            Console.WriteLine("Try A");
        }
    }

    class B : A
    {
        public int item = 7;
        // method:
        public void x()
        {
            Console.WriteLine("Try B");
        }
    }

    class C : A
    {
        // method:
        public void x()
        {
            Console.WriteLine("Try C");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();

            A a2 = new B(); // try A
            // a2 has ho access to data from class B
            a2.x();

            A a3 = new C();
            a3.x(); // try A


            // Access class B and C methods:
            B b1 = new B();
            b1.item = 6;
            b1.x(); // Try B

            C c1 = new C();
            c1.x(); // Try C



            Console.ReadKey();
        }
    }
}