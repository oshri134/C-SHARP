using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 4, num2 = 7;

            Console.WriteLine($"before swapping: num1 = {num1}, num2 = {num2}");
            swap(ref num1, ref num2);

            // value type: when we send parameters to function - we send the value, and not the address. 
            Console.WriteLine($"after swapping: num1 = {num1}, num2 = {num2}");

            /*
             * ref: ref keyword will send the address of that variable, instead of the value. 
             * 
             * result: 
             * before swapping: num1 = 4, num2 = 7
               after swapping: num1 = 7, num2 = 4
            */

            Console.ReadKey();
        }

        // swap numbers: 
        static void swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
       
    }
}
