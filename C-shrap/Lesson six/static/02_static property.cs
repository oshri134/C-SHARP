using System;

namespace Lesson06
{

    class Computer
    {
        // static property - is in the class level. can contain global data
        public static int NumOfComputers;

        public Computer()
        {
            NumOfComputers++;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Computer.NumOfComputers); // 0

            Computer c1 = new Computer();
            Computer c2 = new Computer();
            Computer c3 = new Computer();
            Computer c4 = new Computer();

            Console.WriteLine(Computer.NumOfComputers); // 4



            Console.ReadKey();
        }
    }
}
