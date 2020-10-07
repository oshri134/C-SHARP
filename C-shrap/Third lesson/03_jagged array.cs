using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Jagged array - מערך משונן
             * each row can have diffrent amount of items. 
             */

            string[][] jaggedArray = new string[3][]
            {
                new string[3] {"1", "2", "3" },
                new string[5] {"4", "5", "6", "7","8" },
                new string[2] {"9","10"}
            };

            foreach (string[] row in jaggedArray)
            {
                foreach (string col in row)
                {
                    Console.Write($"[{col}] ");
                }
                Console.WriteLine();
            }

            /*
                [1] [2] [3]
                [4] [5] [6] [7] [8]
                [9] [10]
            */

            Console.ReadKey();
        }
    }
}
