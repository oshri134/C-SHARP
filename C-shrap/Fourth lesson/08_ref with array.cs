using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // reference type: array, object, class. 
            // arr - containes the address of the first element in the array. 

            string[] arr = new string[3] { "a", "b", "c" };
            printArr(arr);

            changeItem(arr);
            printArr(arr);


            Console.ReadKey();
        }

        static void changeItem(string[] arr)
        {
            arr[0] = "X";
        }

        static void printArr(string[] arr)
        {
            foreach (string item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
       
    }
}
