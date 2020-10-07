using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays:

            // new - will create a new array object. 
            int[] arr1 = new int[3];
            Console.WriteLine(arr1); // System.Int32[]

            // loop over empty array - 0 is the default for int32:
            Console.WriteLine("----- Before data insertion: -----");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"index: {i}, has value: {arr1[i]}");
            }

            // insert data to arr1
            arr1[0] = 2;
            arr1[1] = 4;
            arr1[2] = 6;

            Console.WriteLine("\n----- After data insertion: -----");

            // loop over empty array - print the new variables:
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"index: {i}, has value: {arr1[i]}");
            }

            Console.ReadKey();
        }
    }
}
