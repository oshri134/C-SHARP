using System;

namespace Lesson03
{
    class Program
    {
        static void Main(string[] args)
        {
            // matrix: first way: specify length of matrix in initializtion line: 
            int[][] matrix1 = new int[2][];
            matrix1[0] = new int[] { 1, 2, 3 };
            matrix1[1] = new int[] { 4, 5, 6 };

            // matrix: second way: initialize all values in the same line:
            string[][] matrix2 = new string[2][] { new string[] { "a", "b"}, new string[] { "c", "d" } };

            // matrix: third way: initialize all values in the same line (without number of rows):
            bool[][] matrix3 = new bool[][] { 
                new bool[] { true, true}, 
                new bool[] { false, false } 
            };
        }
    }
}
