using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * create an array type: boolean, insert 5 items to the array. 
             * use for-loop to print each item in diffrent line. 
             * 
             * create matrix type: string, with 3 rows. each row will have 4 items (abc). 
             * use nested for-loop to print each item in a diffrent line. 
             */

            // example:
            bool[] arr = new bool[3] { true, false, true };

            string[][] matrix = new string[2][] { 
                new string[] { "a", "b" }, 
                new string[] { "c", "d" } 
            };


            // ------------ for loop: --------------------
            Console.WriteLine("------------ for loop array: --------------------");

            for (int item = 0; item < arr.Length; item++)
            {
                Console.WriteLine($" index: [{item}], value {arr[item]}");
            }

            // matrix.Length - returns the number of rows in a matrix:
            Console.WriteLine("\n\n------------ for loop matrix: --------------------");

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.WriteLine($" index: [{row}][{col}], value {matrix[row][col]}");
                }
            }

            // ------------ foreach loop: --------------------
            // foreach - goes on value. 

            Console.WriteLine("\n\n------------ foreach loop array: --------------------");
            foreach (bool item in arr)
            {
                Console.Write($"{item}, ");
            }

            Console.WriteLine("\n\n------------ foreach loop matrix: --------------------");
            foreach (string[] row in matrix)
            {
                foreach (string col in row)
                {
                    Console.Write($"[{col}] ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
