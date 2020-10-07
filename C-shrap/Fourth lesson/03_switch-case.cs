using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // switch case:

            /*
             * ask from the user a number (represents a day of the week)
             * print with switch-case the day(name) of the week
             * if 5, 6, 7 -> return "Weekend"
             */

            Console.WriteLine("Please enter a number (1-7): ");
            int dayOfWeek = Convert.ToInt32(Console.ReadLine());

            switch (dayOfWeek)
            {
                case 1: Console.WriteLine("Sunday"); break;
                case 2: Console.WriteLine("Monday"); break;
                case 5:
                case 6:
                case 7: Console.WriteLine("Weekend"); break;
                default: Console.WriteLine("Invalid input!"); break;
            }

            Console.ReadKey();
        }
    }
}
