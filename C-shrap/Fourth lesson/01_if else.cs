using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            bool flag = true;
            int variable = 10;

            // if statement: returns boolean value: true / false
            if (flag)
            {
                // flag == true:
                Console.WriteLine("flag is true");
            }
            else
            {
                // flag == false:
                Console.WriteLine("flag is false");
            }
            // flag is true


            // ------------------------
            if (!flag)
            {
                // flag == false:
                Console.WriteLine("flag is false");
            }
            else
            {
                // flag == true:
                Console.WriteLine("flag is true");
            }


            // ------------------------
            if (variable > 10)
            {
                Console.WriteLine("variable is above 10");
            }
            else if(variable < 10)
            {
                Console.WriteLine("variable is below 10");
            }
            else
            {
                Console.WriteLine("variable = 10");
            }

            Console.ReadKey();
        }
    }
}
