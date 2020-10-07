using System;
using System.Runtime.InteropServices;

namespace Lesson07
{

    class A
    {
        public string currDate()
        {
            return "Today is: 01/09/2020";
        }
    }

    class B : A
    {
        public string currDate()
        {
            return base.currDate() + ' ' + "and the third day";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            B b1 = new B();
            Console.WriteLine(b1.currDate()); // Today is: 01/09/2020 and the third day
            Console.ReadKey();
        }
    }
}
