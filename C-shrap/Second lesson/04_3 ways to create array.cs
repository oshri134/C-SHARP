using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // first way to create array : define length and insert data after initialization line. 
            int[] arr1 = new int[3];
            arr1[0] = 2;
            arr1[1] = 4;
            arr1[2] = 6;

            // second way to create array : define length and insert data in initialization line. 
            int[] arr2 = new int[3] { 1, 2, 3 };

            // third way to create array : insert data in initialization line, without length. 
            // the length will be defined by the values.  
            int[] arr3 = new int[] { 8, 16, 24 };

            // length: 
            Console.WriteLine($"Length of arr1: {arr1.Length}"); // 3
            Console.WriteLine($"Length of arr2: {arr2.Length}"); // 3
            Console.WriteLine($"Length of arr3: {arr3.Length}"); // 3

            Console.ReadKey();
        }
    }
}
