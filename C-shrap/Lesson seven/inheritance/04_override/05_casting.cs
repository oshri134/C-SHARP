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
            // casting - המרה מסוג טיפוס אחד לסוג טיפוס אחר
            A a1 = new B();
            
            // is - is a keyword, that checks if instance is part of the class: 
            if(a1 is B)
            {
                // explicit conversion:
                Console.WriteLine(((B)a1).item1);
                Console.WriteLine(((B)a1).item2);
            }

            Console.ReadKey();
        }
    }
}
