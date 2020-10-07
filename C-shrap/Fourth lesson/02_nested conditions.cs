using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // will always run
            if (true)
            {

            }

            // will never run
            if (false)
            {

            }

            // nested conditions - תנאי בתוך תנאי
            int age = 136;
            if(age >= 18)
            {
                if (age <= 120)
                {
                    Console.WriteLine("Adult and valid");
                }
                else
                {
                    Console.WriteLine("Not valid age");
                }
            }
            Console.ReadKey();
        }
    }
}
