using System;

namespace Lesson08
{
    class A
    {
        // method:
        public virtual void x()
        {
            Console.WriteLine("Try A");
        }
    }

    class B : A
    {
        public int item = 7;
        // method:
        public override void x()
        {
            Console.WriteLine("Try B");
        }
    }

    class C : A
    {
        // method: - new keyword will remove the green flag(warning)
        public new void x()
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
            a3.x(); // Try A

            B b1 = new B();
            b1.x(); // Try B

            Console.ReadKey();
        }
    }
}using System;

namespace Lesson08
{
    class A
    {
        // method:
        public virtual void x()
        {
            Console.WriteLine("Try A");
        }
    }

    class B : A
    {
        public int item = 7;
        // method:
        public override void x()
        {
            Console.WriteLine("Try B");
        }
    }

    class C : A
    {
        // method: - new keyword will remove the green flag(warning)
        public new void x()
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
            a3.x(); // Try A

            B b1 = new B();
            b1.x(); // Try B

            Console.ReadKey();
        }
    }
}