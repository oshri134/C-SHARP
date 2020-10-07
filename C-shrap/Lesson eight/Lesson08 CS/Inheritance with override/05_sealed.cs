using System;

namespace Lesson08
{
    class A
    {
        public virtual void x()
        {
            Console.WriteLine("Try A");
        }
    }

    class B : A
    {
        public sealed override void x()
        {
            Console.WriteLine("Try B");
        }
    }

    class C : B
    {
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
            A a2 = new B();
            A a3 = new C();

            a1.x(); // Try A
            a2.x(); // Try B
            a3.x(); // Try B

            Console.ReadKey();
        }
    }
}