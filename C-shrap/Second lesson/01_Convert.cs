using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hello lesson 02";
            int num1 = 45;

            // get type - will return the type of a variable:
            Console.WriteLine(str.GetType()); // System.String
            Console.WriteLine(num1.GetType()); // System.Int32


            // convert: will convert string to int:
            string newStr = "34";
            int res = Convert.ToInt32(newStr);

            Console.WriteLine($"res = {res}, type: {res.GetType()}"); // res = 34, type: System.Int32



            Console.ReadKey();
        }
    }
}
