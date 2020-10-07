using System;

namespace lesson01
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = "hello";
            bool b1 = true;
            int num = 34;

            Console.WriteLine($" str: {str}, type: {str.GetType()}");
            Console.WriteLine($" b1: {b1}, type: {b1.GetType()}");
            Console.WriteLine($" num: {str}, type: {num.GetType()}");

            /*
             * 
                 str: hello, type: System.String
                 b1: True, type: System.Boolean
                 num: hello, type: System.Int32
            */
            Console.ReadKey();
        }
    }
}
