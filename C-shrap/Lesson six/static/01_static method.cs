using System;

namespace Lesson06
{

    class A
    {
        // access this method - by instance
        public void sayHello()
        {
            Console.WriteLine("Hello from regular function");
        }

        // static method - by class (no need to create an instance)
        public static void sayBye()
        {
            Console.WriteLine("Bye from static function");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            a1.sayHello();
            // a1.sayBye();  -> ERROR


            // the only way to access static method - is by the name of the class
            A.sayBye();



            Console.ReadKey();
        }
    }
}
