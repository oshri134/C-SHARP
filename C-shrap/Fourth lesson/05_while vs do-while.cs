using System;

namespace _04Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // while - will run only if condition = true. 
            Console.WriteLine("------ while --------");
            int counter = 3;
            while(counter > 3)
            {
                Console.Write($"{counter} ");
                counter--;
            }
            // output: ----



            // do - while: will run at least once, and then checks the condition
            Console.WriteLine("\n------ do while --------");
            counter = 3;
            do
            {
                Console.Write($"{counter} ");
                counter--;
            } while (counter > 3);
            // output: 3


          
            Console.ReadKey();
        }
    }
}
