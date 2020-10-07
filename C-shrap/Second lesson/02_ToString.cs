using System;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {

            // ToString() - is a function that will convert from number to string. 
            int num1 = 265;

            string str1 = num1.ToString(); // "256"

            Console.WriteLine($"num1 = {num1}, type {num1.GetType()}");
            Console.WriteLine($"str1 = {str1}, type {str1.GetType()}");

            /*
             *  num1 = 265, type System.Int32
                str1 = 265, type System.String
            */


            // Convert types:

            string newstr = "12";

            double d1 = Convert.ToDouble(newstr);

            // create string with "true", and convert it to new variable with type boolean.  

            string boolValue = "true";
            bool res = Convert.ToBoolean(boolValue);

            Console.WriteLine($"res = {res}, type : {res.GetType()}"); // res = True, type : System.Boolean


            Console.ReadKey();
        }
    }
}
